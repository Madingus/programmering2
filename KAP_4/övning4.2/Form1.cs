using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace övning4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgOpenFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream instream = new FileStream(dlgOpenFile.FileName, FileMode.Open, FileAccess.Read);

                StreamReader reader = new StreamReader(instream);

                string fileText = reader.ReadToEnd();

                // tbxFörnamn.Text = fileText; ??

                reader.Dispose();

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            DialogResult result = dlgSaveFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream outstream = new FileStream(dlgSaveFile.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                StreamWriter writer = new StreamWriter(outstream);

                writer.Write("Förnamn: " + tbxFörnamn.Text + "\r\n");
                writer.Write("Efternamn: " + tbxEfternamn.Text + "\r\n");
                writer.Write("Epost: : " + tbxEpost.Text + "\r\n");
                writer.Write("telefonnummer: " + tbxTelefon.Text + "\r\n");

                writer.Dispose();
                
                
            }
        }
    }
}
