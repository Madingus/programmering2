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

namespace övning5._2_Server
{

    

    public partial class Form1 : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        int port = 12345;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStartaServer_Click(object sender, EventArgs e)
        {
            // som i app.listen i javascript, hittar porten så att man kan ansluta till programmet från klienten
            lyssnare = new TcpListener(IPAddress.Any, port);
            // startar servern
            lyssnare.Start();
            //väntar på "Connect" i klienten
            klient = lyssnare.AcceptTcpClient();

            

           
        }

        private void BtnRecieveMessage_Click(object sender, EventArgs e)
        {

            byte[] inData = new byte[256];
            //väntar på "Send" från klienten
            int antalByte = klient.GetStream().Read(inData, 0, inData.Length); //?

            tbxInbox.Text = Encoding.Unicode.GetString(inData, 0, antalByte);
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
