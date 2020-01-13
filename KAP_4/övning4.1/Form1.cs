using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            DialogResult r = clrDialog.ShowDialog();
                if ( r == DialogResult.OK)
                {
                    btnColor.BackColor = clrDialog.Color;
                }
            
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            DialogResult r = fldrDialog.ShowDialog();
            if (r == DialogResult.OK)
            {
                btnFolder.Text = fldrDialog.SelectedPath;
            }
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            DialogResult r = fontDialog.ShowDialog();
            if (r == DialogResult.OK)
            {
                btnFont.Font = fontDialog.Font;
            }
        }
    }
}
