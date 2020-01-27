using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning3._7
{
    public partial class Form1 : Form
    {
        private List<Match> matcher = new List<Match>();



        public Form1()
        {
            
            InitializeComponent();
        }


        private void dvgMatcher_UserAddedRow(object sender, DataGridViewCellEventArgs e)
        {
            Match nyMatch = new Match();
            matcher.Add(nyMatch);
        }

        private void dvgMatcher_CellEndEdit(object senderm, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; //index för den rad som har redigerats

            if (e.ColumnIndex == 0)
            {
                matcher[i].HemmaLag = (string)dvgMatcher.Rows[i].Cells[0].Value;
            }
            else if (e.ColumnIndex == 1)
            {
                matcher[i].BortaLag = (string)dvgMatcher.Rows[i].Cells[1].Value;
            }
            else if (e.ColumnIndex == 2)
            {
                matcher[i].MålHemmaLag = int.Parse((string)dvgMatcher.Rows[i].Cells[2].Value);
            }
            else if (e.ColumnIndex == 3)
            {
                matcher[i].MålHemmaLag = int.Parse((string)dvgMatcher.Rows[i].Cells[3].Value);
            } 


        }

        private void dvgMatcher_UserDeletingRows(object sender, DataGridViewRowCancelEventArgs e)
        {
            Match match = e.Row.Tag as Match;
            matcher.Remove(match);
        }




        private void btnMålrikast_Click(object sender, EventArgs e)
        {
            string hemmalag = "";
            string bortalag = "";
            int antalMål = 0;
            for (int i =0; i<matcher.Count; i++)
            {
                if(matcher[i].MålHemmaLag + matcher[i].målBortaLag > antalMål)
                {
                    hemmalag = matcher[i].HemmaLag;
                    bortalag = matcher[i].BortaLag;
                    antalMål = matcher[i].MålHemmaLag + matcher[i].målBortaLag;
                }
            }
            tbxMålrikast.Text = hemmalag + " " + bortalag + ": " + antalMål;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DvgMatcher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


public class Match
{                                       
    public string HemmaLag { get; set; }
    public string BortaLag { get; set; }
    public int MålHemmaLag { get; set; }
    public int målBortaLag { get; set; }
}
