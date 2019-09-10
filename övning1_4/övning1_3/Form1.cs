using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            PictureBox[,] bilder = new PictureBox[5, 5];

            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; r++)
                {



                    bilder[r, c] = new PictureBox()
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }
    }
}
