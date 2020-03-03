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

namespace övning_5._2_Klient
{
    public partial class Form1 : Form
    {
        TcpClient client;
        int port = 12345;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSayHi_Click(object sender, EventArgs e)
        {
            IPAddress adress = IPAddress.Parse(tbxServerAdress.Text);
            client = new TcpClient();
            client.NoDelay = true;
            client.Connect(adress, port);

            


        }

        private void BtnSendMessage_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                byte[] utdata = Encoding.Unicode.GetBytes(tbxKlientMessage.Text);
                client.GetStream().Write(utdata, 0, utdata.Length);
                
            }
        }
    }
}
