using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace RemoteFileManagement
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        TcpListener server;
        TcpClient client;

        private void button1_Click(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Loopback, 2024);
            server.Start();
            Thread client_thread = new Thread(ListenThread);
            client_thread.IsBackground = true;
            client_thread.Start();
            
            

        }

        private async void ListenThread()
        {
            client = server.AcceptTcpClient();
            NetworkStream stream = client.GetStream();
            while (true)
            {
                byte[] buffer = new byte[1024];
               await stream.ReadAsync(buffer, 0, buffer.Length);
                string text = Encoding.ASCII.GetString(buffer);
                richTextBox1.Text += text;
            }
        }

        private async void ButtonSend_Click(object sender, EventArgs e)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = Encoding.ASCII.GetBytes(textBox1.Text);
            await stream.WriteAsync(buffer, 0, buffer.Length);
        }
    }
}
