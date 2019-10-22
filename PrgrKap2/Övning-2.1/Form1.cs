using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._1
{
    public partial class Form1 : Form
    {
        private List<Media> mediaList = new List<Media>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {





        }

        private void BtnBok_Click(object sender, EventArgs e)
        {

            Bok b = new Bok(tbxBokTitel.Text, int.Parse(tbxBokSidor.Text)); {


                mediaList.Add(b);

                lbxLista.Items.Add(b);
            }
            

        }

        private void BtnLjud_Click(object sender, EventArgs e)
        {

            Ljudspår l = new Ljudspår(tbxLjudTitel.Text, int.Parse(tbxLjudSpeltid.Text));
            {

                mediaList.Add(l);

                lbxLista.Items.Add(l);

            }


        }

        private void Button3_Click(object sender, EventArgs e)
        {

            Film f = new Film(tbxFilmTitel.Text, int.Parse(tbxFilmSpeltid.Text), tbxFilmUpplösning.Text);
            {

                mediaList.Add(f);

                lbxLista.Items.Add(f);

            }

        }
    }
}
