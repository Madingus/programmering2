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


        private void dvgMatcher_CellEndEdit(object senderm, DataGridViewCellEventArgs e)
        {



        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
