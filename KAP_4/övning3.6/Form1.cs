using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning3._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RbnMiddle_CheckedChanged(object sender, EventArgs e)
        {
            ribxResult.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void RibxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void RbnRight_CheckedChanged(object sender, EventArgs e)
        {
            ribxResult.SelectionAlignment = HorizontalAlignment.Right;
          
        }

        private void RbnLeft_CheckedChanged(object sender, EventArgs e)
        {
            ribxResult.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void RbnColor_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult r = colorDialog.ShowDialog();
            if (r == DialogResult.OK)
            {
               ribxResult.SelectionColor = colorDialog.Color;
                rbnColor.BackColor = colorDialog.Color;

            }

        }
    }
}
