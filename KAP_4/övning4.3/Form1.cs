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

namespace övning4._3
{
    public partial class Form1 : Form
    {
        private List<Kontakt> kontakter = new List<Kontakt>();

        public Form1()
        {
            InitializeComponent();
        }

        private void TbxFörnamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void LäggTillToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = dlgOpenFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileStream instream = new FileStream(dlgOpenFile.SelectedPath, FileMode.OpenOrCreate, FileAccess.Write);
                

                StreamReader reader = new StreamReader(fs);

                string fileText = reader.ReadToEnd();

                string förnamn = reader.ReadLine();
                while (förnamn != null)
                {
                    kontakter.Add(new Kontakt()
                    {

                        förnamn = förnamn,
                        efternamn = reader.ReadLine(),
                        epost = reader.ReadLine(),
                        telefonnummer = reader.ReadLine()


                    });

                }
            }


        }

        private void SparaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Kontakt k in kontakter)
            {
                FileStream outstream = new FileStream(dlgSaveFile.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                StreamWriter writer = new StreamWriter(outstream);

                writer.Write(k.förnamn);
                writer.Write(k.efternamn);
                writer.Write(k.epost);
                writer.Write(k.telefonnummer);



            }
        }
    }
}
