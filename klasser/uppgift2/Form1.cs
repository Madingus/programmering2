using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift2
{
    public partial class Form1 : Form
    {
        int antalReg = 0;
        List <Shoot> shootList = new List <Shoot>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            int score = int.Parse(tbxPoints.Text);
            Shoot s = new Shoot(name, score);
            shootList.Add(s);

            tbxList.Items.Add(s);

            


            MessageBox.Show("Score Registered");
            antalReg++;
        }
    }
}
