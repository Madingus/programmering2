using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKör_Click(object sender, EventArgs e)
        {
            FontStyle stil = FontStyle.Regular;

            if (cbxFet.Checked)
            {
                stil = stil | FontStyle.Bold;
            }
            if (cbxKursiv.Checked)
            {
                stil = stil | FontStyle.Italic;
            }
            if (cbxUnderline.Checked)
            {
                stil = stil | FontStyle.Underline;
            }

            int size = int.Parse(tbxStorlek.Text);




            if (size > 0)
            {
                Font font = new Font(tbxTecken.Text, size, stil);
                tbxList.Font = font;
            }
            else
            {
                Font font = new Font(tbxTecken.Text, 10, stil);
                tbxList.Font = font;
            }




        }
    }
}
