using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_2._1__media__bok_klasser_
{
    public partial class Form1 : Form
    {
        private List<Media> mediaLista = new List<Media>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Film filmKopia = new Film(tbxFilmUpplösning.Text, tbxFilmTitel.Text, double.Parse(tbxFilmSpeltid.Text));  // saknar upplösning

            mediaLista.Add(filmKopia);

            lbxList.Items.Add(filmKopia);

        }

        private void BtnBok_Click(object sender, EventArgs e)
        {
            Bok m = new Bok(int.Parse(tbxBokSidor.Text), tbxBokTitel.Text);

            mediaLista.Add(m);

            lbxList.Items.Add(m);

            

        }

        private void BtnLjudspår_Click(object sender, EventArgs e)
        {
            Ljudspår l = new Ljudspår(double.Parse(tbxLjudSpeltid.Text), tbxLjudTitel.Text);

            mediaLista.Add(l);
            lbxList.Items.Add(l);


        }
    }
}
