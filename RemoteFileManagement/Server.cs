using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using static System.Windows.Forms.LinkLabel;
using System.IO.Pipes;

namespace RemoteFileManagement
{
    public partial class Server : Form
    {
        TcpListener server;
        //RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        public Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void ButtonListen_Click(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Loopback, 2024);
            server.Start();
            Thread listen_thread = new Thread(ListenThread);
            listen_thread.IsBackground = true;
            listen_thread.Start();
            RichTextBoxOutput.AppendText("Server started on port 2024\n");
        }

        private async void ClientThread(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            RichTextBoxOutput.AppendText("Client connected: " + client.Client.RemoteEndPoint + "\n");
            
            //receive public key from client
            byte[] publickey_client_bytes = new byte[243];
            stream.Read(publickey_client_bytes, 0, publickey_client_bytes.Length);
            string publickey_client = Encoding.ASCII.GetString(publickey_client_bytes);
            
            //import public key
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publickey_client);

            while(true)
            {
                byte[] buffer = new byte[1024];
                stream.Read(buffer, 0, buffer.Length);
                string path = (string)Deserialize(buffer);

                //hard buffer for incoming file path request is 1024 bytes
                //send requested file to client
                if (path != null)
                {
                    //send file
                    try
                    {
                        string outputpath = await EncryptFileAES(path, rsa);
                        
                        //open encryted file
                        FileStream file = new FileStream(outputpath, FileMode.Open, FileAccess.Read);
                        byte[] fileBytes = new byte[file.Length];

                        //send file length
                        byte[] file_len = Serialize(fileBytes.Length.ToString());
                        Console.WriteLine(file_len.Length);
                        stream.Write(file_len, 0, file_len.Length);

                        byte[] fileBuffer = new byte[1024*5];
                        int count;
                        while ((count = file.Read(fileBuffer, 0, fileBuffer.Length)) > 0)
                        {
                            stream.Write(fileBuffer, 0, count);
                        }
                            Console.WriteLine(count);

                        stream.Flush();

                    }
                    catch
                    {

                    }

                    ////send file name
                    //try
                    //{
                    //    string fileName = Path.GetFileName(path);
                    //    byte[] fileNameBytes = Encoding.ASCII.GetBytes(fileName);
                    //    stream.Read(fileNameBytes, 0, fileNameBytes.Length);
                        

                    //}
                    //catch
                    //{
                                                
                    //}
                }
            }
        }

        private async Task<string> EncryptFileAES(string path, RSACryptoServiceProvider rsa)
        {
            return await Task.Run(() => {
                //string path = (string)obj;
                string outputpath = Path.ChangeExtension(path, ".enc");
                if (!File.Exists(path))
                {
                    outputpath = null;
                    return outputpath;
                }
                if (File.Exists(outputpath))
                {
                    File.Delete(outputpath);
                }
                //handle input file not found
                Aes aes = Aes.Create();
                ICryptoTransform transform = aes.CreateEncryptor();
                int aesIVLength = aes.IV.Length;
                byte[] aesIVlen = BitConverter.GetBytes(aesIVLength);

                //encrypt aes key with rsa for secure transfer
                byte[] encryptedAESKey = rsa.Encrypt(aes.Key, false);
                byte[] encryptedAESKeyLength = BitConverter.GetBytes(encryptedAESKey.Length);

                FileStream filestream_out = null;
                try
                {
                    filestream_out = new FileStream(outputpath, FileMode.Create, FileAccess.Write);
                    filestream_out.Seek(0, SeekOrigin.Begin);
                    //write encrypted aes key length to file
                    filestream_out.Write(encryptedAESKeyLength, 0, 4);
                    // 0 to 4 bytes are IV length
                    filestream_out.Write(aesIVlen, 0, 4);
                    //write encrypted aes key to file
                    filestream_out.Write(encryptedAESKey, 0, encryptedAESKey.Length);
                    //write IV to file
                    filestream_out.Write(aes.IV, 0, aesIVLength);
                }
                catch
                {
                    outputpath = null;
                    return outputpath;
                }

                try
                {
                    CryptoStream cryptoStream = new CryptoStream(filestream_out, transform, CryptoStreamMode.Write);
                    //encrypt a chunk at a time
                    int count = 0;
                    int offset = 0;

                    //set block size to 1/8 of the aes block size
                    int blockSize = aes.BlockSize / 8;
                    byte[] data = new byte[blockSize];
                    int bytesRead = 0;

                    FileStream fileStream_in = new FileStream(path, FileMode.Open, FileAccess.Read);
                    do
                    {
                        count = fileStream_in.Read(data, 0, blockSize);
                        offset += count;
                        cryptoStream.Write(data, 0, count);
                        bytesRead += blockSize;
                    }
                    while (count > 0);

                    cryptoStream.FlushFinalBlock();
                    filestream_out.Close();
                    fileStream_in.Close();
                }
                catch
                {
                    outputpath = null;
                    return outputpath;
                }

                return outputpath;
            });
        }

        private void ListenThread()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Thread client_thread = new Thread(ClientThread);
                client_thread.IsBackground = true;
                client_thread.Start(client);
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

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            string output= null;
            //EncryptFileAES(TextBoxPathTest.Text,output, rsa);
            MessageBox.Show(output);
        }

        private void ButtonTest2_Click(object sender, EventArgs e)
        {
            //string output = null;
            //DecryptFileAES(Path.ChangeExtension(TextBoxPathTest.Text, ".enc"), "test.png", output, rsa);
            //MessageBox.Show(output);
        }
    }
}
