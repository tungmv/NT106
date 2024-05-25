using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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



        private async void DecryptFileAES(string path, string filename, string result, RSACryptoServiceProvider rsa)
        {
            result = await Task.Run(() =>
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
            client.Connect("127.0.0.1", 2024);
            MessageBox.Show("Connected to server");
            ButtonConnect.Enabled = false;
            ButtonSendRequest.Enabled = true;

            NetworkStream memoryStream = client.GetStream();

            //expore rsa public key to Xml and send to server
            byte[] public_key = Encoding.ASCII.GetBytes(rsa.ToXmlString(false));
            memoryStream.Write(public_key, 0, public_key.Length);

        }

        private void ButtonSendRequest_Click(object sender, EventArgs e)
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
    }
}
