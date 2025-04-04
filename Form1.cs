using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FlappyBirdGame
{
    public partial class Form1: Form
    {

        int pipeSpeed = 5;
        int gravity = 8;
        int score = 0;
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private Random rn = new Random(); // Move Random outside the method


        bool pipePassed = false;
        int count = 0;
        private void gameTimerEvent(object sender, EventArgs e)
        {
            pictureBird.Top += gravity;

            pictureGround.Left -= pipeSpeed;
           
    

            pictureBottom.Left -= pipeSpeed;
            pictureTop.Left -= pipeSpeed;



           
            // Reset positions for horizontal movement
            if (pictureBottom.Left < -175)
            {
                pictureBottom.Left = 600;
                pictureBottom.Top = rn.Next(184,556); // Set a fixed height for the bottom pipe
                pictureTop.Top = pictureBottom.Top - pictureTop.Height - 150;
                pictureTop.Left = pictureBottom.Left;
                pipePassed = false;
            }
            if (pictureTop.Left < -175)
            {
                pictureTop.Left = 600;
                pictureTop.Top = rn.Next(-256, -6); // Set a fixed height for the top pipe
            }

            

       

            if (pictureBird.Bounds.IntersectsWith(pictureBottom.Bounds) || pictureBird.Bounds.IntersectsWith(pictureTop.Bounds) ||
                pictureBird.Bounds.IntersectsWith(pictureGround.Bounds) || pictureBird.Bounds.IntersectsWith(panel1.Bounds))   
            {
                gameTimer.Stop();
                panel2.Visible = true;
            }


            if (pictureTop.Left + pictureTop.Width < pictureBird.Left && !pipePassed)
            {
                count++;
                gameScore.Text = count.ToString();
                pipePassed = true; // mark this pipe as passed
            }

            if (count >= 3 && count <= 6)
            {
                pipeSpeed = 7;

            }
            else if (count > 6 && count <= 10)
            {
                pipeSpeed = 9;
            }

            else if (count > 10 && count <= 15)
            {

                pipeSpeed = 11;
            }
            else if (count > 15 && count <= 20)
            {

                pipeSpeed = 13;
            }
            else if (count > 20 && count <= 25)
            {

                pipeSpeed = 15;
            }
            else if (count > 25)
            {

                pipeSpeed = 17;
            }
            else {
                pipeSpeed = 5;
            }
        }

          
        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                gravity = 10;
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {

                gravity = -10;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBird_Click(object sender, EventArgs e)
        {
             
        }

        private void pictureBottom_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            scoreControl.Text = count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            panel2.Visible = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
           
        }
    }
}
