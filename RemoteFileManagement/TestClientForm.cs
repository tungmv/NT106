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
    public partial class TestClientForm : Form
    {
        public TestClientForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        TcpClient client;

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            //connect to server
            client = new TcpClient("127.0.0.1", 2024);
            Thread listen_thread = new Thread(ListenThread);
            listen_thread.IsBackground = true;
            listen_thread.Start();
        }

        private async void ListenThread()
        {
            NetworkStream stream = client.GetStream();
            while (true)
            {
                byte[] buffer = new byte[1024];
                await stream.ReadAsync(buffer, 0, buffer.Length);
                //convert byte array to string
                string text = Encoding.ASCII.GetString(buffer);
                richTextBox1.Text += text;
            }
        }

        private async void ButtonSend_Click(object sender, EventArgs e)
        {
            //send text to server
            Stream stream = client.GetStream();
            byte[] buffer = Encoding.ASCII.GetBytes(textBox1.Text);
            await stream.WriteAsync(buffer, 0, buffer.Length);
        }
    }
}
