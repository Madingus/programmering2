using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace övning5._3_TCP_ServerFixed
{
    public partial class Form1 : Form
    {
        int port = 1234;
        TcpListener listener;
        TcpClient client;

        public Form1()
        {
            InitializeComponent();

            try
            {
                listener = new TcpListener(IPAddress.Any, port);
                listener.Start();
               

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text); return;
            }
            StartRecieving();

        }
        public async void StartRecieving()
        {
            try
            {
                client = await listener.AcceptTcpClientAsync();

            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }

            StartReading(client);

        }

        public async void StartReading(TcpClient k)
        {
            byte[] buffer = new byte[1024];

            int n = 0;
            try
            {
                n = await k.GetStream().ReadAsync(buffer, 0, buffer.Length);
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }

            tbxInkorg.AppendText(Encoding.Unicode.GetString(buffer, 0, n));
            StartReading(k);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
