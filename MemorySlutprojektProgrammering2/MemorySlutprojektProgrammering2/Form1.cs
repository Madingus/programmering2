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
        bool allowClick = false;
        PictureBox firstGuess;
        Random rnd = new Random(); //creates a random number generator class


        Timer clickTimer = new Timer(); // the timer that will be used to "hide" all the pictureboxes
        Timer timer = new Timer { Interval = 1000 }; //creates a timer with the interval 1000 milisecodnds

        private Spelare spelare1 = new Spelare(0,0,false);
        private Spelare spelare2 = new Spelare(0,0, false);
        
        

        private int _ticks; //keeps track of the timer

        public Form1()
        {
            InitializeComponent();
        }

        private PictureBox[] pictureBoxes //put this in a class later on?
        {
            get { return Controls.OfType<PictureBox>().ToArray(); } //adds all the pictures in to an array for easier use
        }

        private static IEnumerable<Image> images // this function links the images that are in the Resourses tab so we can acess them
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.img1,
                    Properties.Resources.img2,
                    Properties.Resources.img3,
                    Properties.Resources.img4,
                    Properties.Resources.img5,
                    Properties.Resources.img6,
                    Properties.Resources.img7,
                    Properties.Resources.img8

                };
            }
        }

        private void ResetImages() //resets all the images by making all of the pictures visible
        {
            foreach(var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
        }

        private void HideImages() //makes a function that loops through all the pictureBoxes and turns them in to question marks so that you cant see the "front side"
        {
            foreach(var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.question;
            }
        }

        private PictureBox getFreeSlot() //creates a function that will return a random number based on the ammount of pictures boxes, will be used to shuffle the pictures
        {
            int num;

            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];
            
        }

        private void setRandomImages() //finds 2 random picturesBoxes that will be used as a match
        {
            foreach (var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e) //"hides" all images with the HideImages() function
        {
            HideImages();

            allowClick = true;
            clickTimer.Stop();

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            allowClick = true;
            setRandomImages(); //runs the shuffle function
            HideImages(); //runs the hide images function
            clickTimer.Interval = 1000; // sets the interval timer to 1000 miliseconds
            clickTimer.Tick += CLICKTIMER_TICK; //when the clickTimer ticks, it also increases the value of CLICKTIMER
            btnStart.Enabled = false;


            gameTimer.Start(); //starts the timer when the "start game button is clicked"
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            _ticks++;
            lblTime.Text = _ticks.ToString(); // shows the timer tick every second
        }

        private void clickImage(object sender, EventArgs e) //when an image is clicked this function runs
        {
            

            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null) //this function identifies which pictureBox was clicked
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return; // if the picrure matches, the value of the found picture becomes null
            }
            pic.Image = (Image)pic.Tag;
            
            if (pic.Image == firstGuess.Image && pic != firstGuess) //if the 2 pictures chosen are not matching
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;
                }
                HideImages(); //hides the images after an attempt
            }
            
            else
            {
                allowClick = false;
                clickTimer.Start();

                firstGuess = null;
                if (pictureBoxes.Any(p => p.Visible)) return; // checks if all pictureBoxes are visible, and the game stops when all are visible
                MessageBox.Show("you win! play again?"); // if all picture boxes are visible you win and the pictures are reset
                ResetImages();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
