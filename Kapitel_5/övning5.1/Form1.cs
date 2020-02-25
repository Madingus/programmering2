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

namespace övning5._1 //server
{
    public partial class Form1Server : Form
    {
        public Form1Server()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LbxInkorg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnRecieve_Click(object sender, EventArgs e)
        {
            IPEndPoint klientEndPoint = new IPEndPoint(IPAddress.Any, 0);
            UdpClient client = new UdpClient(12345);
            byte[] inStream = client.Receive(ref klientEndPoint);
            tbxInbox.Text = Encoding.Unicode.GetString(inStream);

        }
    }
}
