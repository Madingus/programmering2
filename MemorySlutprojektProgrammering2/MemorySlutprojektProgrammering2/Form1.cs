using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemorySlutprojektProgrammering2
{
    public partial class Form1 : Form
    {
        private int _ticks; //keeps track of the timer
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            gameTimer.Start(); //starts the timer when the "start game button is clicked"
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            _ticks++;
            lblTime.Text = _ticks.ToString();
        }
    }
}
