using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteFileManagement
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        TcpClient client;



        private async Task<string> DecryptFileAES(string path, string filename, RSACryptoServiceProvider rsa)
        {
            return await Task.Run(() =>
            {

                //combine file name with path
                string outputpath = Path.Combine(Path.GetDirectoryName(path), filename);

                if (File.Exists(outputpath))
                {
                    File.Delete(outputpath);
                }

                Aes aes = Aes.Create();

                //bytes array to store encrypted aes key length and IV length
                byte[] encrypted_key_len = new byte[4];
                byte[] IV_len = new byte[4];


                FileStream fileStream_in = null;
                try
                {
                    fileStream_in = new FileStream(path, FileMode.Open, FileAccess.Read);
                    fileStream_in.Seek(0, SeekOrigin.Begin);
                    fileStream_in.Read(encrypted_key_len, 0, 3);
                    fileStream_in.Seek(4, SeekOrigin.Begin);
                    fileStream_in.Read(IV_len, 0, 3);
                }
                catch
                {
                    return null;
                }

                //convert byte array to int
                int encrypted_key_length = BitConverter.ToInt32(encrypted_key_len, 0);
                int IV_length = BitConverter.ToInt32(IV_len, 0);

                // Determine the start position of
                // the cipher text (startC)
                // and its length(lenC).
                int startC = encrypted_key_length + IV_length + 8;
                int lenC = (int)fileStream_in.Length - startC;

                //byte array to store encrypted aes key and IV
                byte[] encrypted_key = new byte[encrypted_key_length];
                byte[] IV = new byte[IV_length];


                // Extract the key and IV
                // starting from index 8
                // after the length values.

                try
                {
                    fileStream_in.Seek(8, SeekOrigin.Begin);
                    fileStream_in.Read(encrypted_key, 0, encrypted_key_length);
                    fileStream_in.Seek(8 + encrypted_key_length, SeekOrigin.Begin);
                    fileStream_in.Read(IV, 0, IV_length);
                }

                catch
                {
                    return null;
                }

                byte[] decryptedAESKey = rsa.Decrypt(encrypted_key, false);

                //decrypt the key
                ICryptoTransform transform = aes.CreateDecryptor(decryptedAESKey, IV);

                //decrypt file and write to output path
                FileStream fileStream_out = null;
                try
                {
                    fileStream_out = new FileStream(outputpath, FileMode.Create, FileAccess.Write);
                    int count = 0;
                    int offset = 0;

                    //block size is 1/8 of the aes block size
                    int blockSize = aes.BlockSize / 8;
                    byte[] data = new byte[blockSize];

                    //decrypt a chunk at a time
                    fileStream_in.Seek(startC, SeekOrigin.Begin);
                    CryptoStream cryptoStream = new CryptoStream(fileStream_out, transform, CryptoStreamMode.Write);
                    do
                    {
                        count = fileStream_in.Read(data, 0, blockSize);
                        offset += count;
                        cryptoStream.Write(data, 0, count);
                    }
                    while (count > 0);

                    cryptoStream.FlushFinalBlock();
                }
                catch
                {
                    return null;
                }
                fileStream_in.Close();
                fileStream_out.Close();
                return outputpath;
            });

        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint iPEndPoint = null;
            try
            {
                iPEndPoint = new IPEndPoint(IPAddress.Parse(TextBoxIPAddress.Text), int.Parse(TextBoxPort.Text));
            }
            catch
            {
                MessageBox.Show("Invalid IP Address or Port");
                return;
            }
            try
            {
                client.Connect(iPEndPoint);
            }
            catch
            {
                MessageBox.Show("Failed to connect to server");
                return;
            }
            //MessageBox.Show("Connected to server");
            RichTextBoxOutput.Text = "Connected to server\n";
            ButtonConnect.Enabled = false;
            ButtonSendRequest.Enabled = true;

            NetworkStream memoryStream = client.GetStream();

            //expore rsa public key to Xml and send to server
            byte[] public_key = Encoding.ASCII.GetBytes(rsa.ToXmlString(false));
            memoryStream.Write(public_key, 0, public_key.Length);

        }

        private async void ButtonSendRequest_Click(object sender, EventArgs e)
        {
            byte[] path_bytes = Encoding.ASCII.GetBytes(TextBoxPath.Text);
            if(path_bytes.Length == 0)
            {
                MessageBox.Show("Please enter a path");
                return;
            }
            if (path_bytes.Length > 1024)
            {
                MessageBox.Show("Path is too long");
                return;
            }

            path_bytes = Serialize(TextBoxPath.Text);
            NetworkStream stream = client.GetStream();
            stream.Write(path_bytes, 0, path_bytes.Length);
            
            RichTextBoxOutput.Text += "Requested " + Path.GetFileName(TextBoxPath.Text) + " from server\n";

            //receive encrypted file length
            byte[] encrypted_file_length = new byte[54];
            stream.Read(encrypted_file_length, 0, encrypted_file_length.Length);
            long file_length = long.Parse((string)Deserialize(encrypted_file_length));
            if (file_length == 0)
            {
                MessageBox.Show("File not found on server");
                return;
            }

            RichTextBoxOutput.Text += "Receiving " + file_length.ToString() + " bytes from server\n";

            //output path in current directory
            string output_encryted = Path.Combine(Directory.GetCurrentDirectory(), Path.GetFileName(TextBoxPath.Text));
            output_encryted = Path.ChangeExtension(output_encryted, ".enc");

            if(File.Exists(output_encryted))
            {
                File.Delete(output_encryted);
            }

            //receive encrypted file by chunks

            FileStream fileStream = new FileStream(output_encryted, FileMode.Create, FileAccess.Write);
                byte[] buffer = new byte[1024*5];
                long bytesRead = 0;
                int count;
                while (bytesRead < file_length && (count = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fileStream.Write(buffer, 0, count);
                    bytesRead += count;
                }
            fileStream.Close();

            RichTextBoxOutput.Text += "Received " + file_length.ToString() + " bytes from server\n";

            //decrypt file
            string outputpath = null;
            try
            {
                outputpath = await DecryptFileAES(output_encryted, Path.GetFileName(TextBoxPath.Text), rsa);
            }
            catch
            {
                MessageBox.Show("Error decrypting file");
            }

            RichTextBoxOutput.Text += "File has been decrypted at " + outputpath + "\n";

            //remove encrypted file
            if (File.Exists(output_encryted))
            {
                File.Delete(output_encryted);
            }

        }
        private byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            byte[] data = stream.ToArray();
            stream.Close();
            return data;

        }

        private object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            object obj = formatter.Deserialize(stream);
            stream.Close();
            return obj;
        }
    }
}
