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

namespace övning5__1_UDP_Klient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.Unicode.GetBytes(tbxMessage.Text);

            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            IPEndPoint destination = new IPEndPoint(serverIP, 12345);

            UdpClient klient = new UdpClient();
            klient.Send(message, message.Length, destination);
        }
    }
}
