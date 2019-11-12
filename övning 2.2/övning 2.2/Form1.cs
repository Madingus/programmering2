using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_2._2
{
    public partial class Form1 : Form
    {

        private List<Säljare> säljarLista = new List<Säljare>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSäljare_Click(object sender, EventArgs e)
        {
            


           
            Säljare s = new Säljare(double.Parse(tbxFörsäljareProvision.Text), double.Parse(tbxFörsäljareFörsäljning.Text), tbxFörsäljareNamn.Text);

            säljarLista.Add(s);

            lbxReg.Items.Add(s);

        }

        private void BtnKonsult_Click(object sender, EventArgs e)
        {

        }

        private void BtnKontorist_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
