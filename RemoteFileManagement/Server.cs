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

namespace RemoteFileManagement
{
    public partial class Server : Form
    {
        TcpListener server;
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

        }

        private void ClientThread(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            while(true)
            {
                StreamReader reader = new StreamReader(stream);
                string path = reader.ReadLine();

                //hard buffer for incoming file path request is 1024 bytes
                //send requested file to client
                if (path != null)
                {
                    byte[] buffer = new byte[1024];
                    try
                    {
                        FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
                        int bytesRead = 0;
                        while ((bytesRead = file.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            stream.Write(buffer, 0, bytesRead);
                        }
                        file.Close();

                    }

                    catch
                    {
                        
                    }
                }
            }
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
    }
}
