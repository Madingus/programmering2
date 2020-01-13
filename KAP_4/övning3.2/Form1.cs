using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult r = dialogClr.ShowDialog();
            if (r == DialogResult.OK)
            {
                btnColor.BackColor = dialogClr.Color;
            }
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DialogResult r = dialogFldr.ShowDialog();
            if (r == DialogResult.OK)
            {
                btnFolder.Text = dialogFldr.SelectedPath;
            }
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DialogResult r = dialogFont.ShowDialog();
            if (r == DialogResult.OK)
            {
                btnFont.Font = dialogFont.Font;
            }
        }
    }
}
