﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Kap_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NyttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxResultat.Text = "";
        }

        private void ÖppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgOpenFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream instream = new FileStream(dlgOpenFile.FileName, FileMode.Open, FileAccess.Read);

                StreamReader reader = new StreamReader(instream);

                string fileText = reader.ReadToEnd();

                tbxResultat.Text = fileText;

                reader.Dispose();

            }
        }

        private void SparaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = dlgSaveFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream outstream = new FileStream(dlgSaveFile.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                StreamWriter writer = new StreamWriter(outstream);

                writer.Write(tbxResultat.Text);

                writer.Dispose();

            }

        }
    }
}
