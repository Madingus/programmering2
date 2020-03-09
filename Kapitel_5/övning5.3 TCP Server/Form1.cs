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

namespace övning5._3_TCP_Server
{
    public partial class Form1 : Form
    {
        TcpClient client = new TcpClient();
        int port = 1234;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("help");




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
