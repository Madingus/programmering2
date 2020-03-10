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

namespace övning5._3_TCP_Klient
{
    public partial class Form1 : Form
    {
        TcpClient client = new TcpClient();
        int port = 12345;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void BtnConnect_Click(object sender, EventArgs e)
        {

            if (!client.Connected) StartConnection();


            
        }

        private void StartConnection()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(tbxServerAdress.Text);
                client.ConnectAsync(adress, port);
            }
            catch(Exception error) { MessageBox.Show(error.Message, Text); return; }
            {
                btnConnect.Enabled = false;
                btnRecieve.Enabled = true;

            }
        }

        private void BtnRecieve_Click(object sender, EventArgs e)
         {
            StartConnection("hello");

            }

        public async void StartConnection(string message)
        {
            byte[] outData = Encoding.Unicode.GetBytes("!hello!");
            try
            {
                await client.GetStream().WriteAsync(outData, 0, outData.Length);
            }
            catch(Exception error) { MessageBox.Show(error.Message, Text); return; }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}


