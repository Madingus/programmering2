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

namespace övning5._1_UDP_Klient //Klient
{
    public partial class Form1Klient : Form
    {
        public Form1Klient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void btnSend_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.Unicode.GetBytes(tbxMessage.Text);

            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            IPEndPoint destination = new IPEndPoint(serverIP, 12345);

            UdpClient klient = new UdpClient();
            klient.Send(message, message.Length, destination);

        }
    }
}
