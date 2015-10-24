using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Space_Invaders_With_Classes
{
    public partial class Form1 : Form
    {
        //Global
        int Ship = 1;
        Layout[] arr = new Layout[5];


        public Form1()
        {
            InitializeComponent();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        //Speed
        /////////////////////
        private void lowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer.Interval = 1000;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer.Interval = 750;
        }

        private void highToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer.Interval = 500;
        }
        /////////////////////

        private void Timer_Tick(object sender, EventArgs e)
        {
            int Stopped = 0;
            int Landed = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Pic.Top += 40;

                if (arr[i].Pic.Top >= 270 && !arr[i].Landed)
                {
                    arr[i].Pic.Hide();
                    arr[i].Landed = true;

                    ++Landed;
                }

                Stopped += arr[i].Clicked;
            }

            Landed += int.Parse(Landed_Label.Text);

            Landed_Label.Text = Landed.ToString();

            //Stopped += int.Parse(Stopped_Lapel.Text);

            Stopped_Lapel.Text = (Stopped).ToString();

            if (Landed == arr.Length)
            {
                Timer.Enabled = false;

                DialogResult dialogResult = MessageBox.Show("All Ships Landed, Do you want to play again ?", "YOU LOST !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                    newToolStripMenuItem1_Click(sender, e);

                else
                    Application.Exit();
            }
        }


        //Ship Type
        /////////////////////////////
        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ship = 1;

            foreach (Layout i in arr)
                i.Ship(Ship);

            Panel.Size = new Size(380, 309);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ship = 2;

            foreach (Layout i in arr)
                i.Ship(Ship);

            Panel.Size = new Size(400, 309);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ship = 3;

            foreach (Layout i in arr)
                i.Ship(Ship);

            Panel.Size = new Size(400, 309);
        }
        //////////////////////////////

        //Start/Stop Button
        private void Start_Button_Click(object sender, EventArgs e)
        {
            Timer.Enabled = !Timer.Enabled;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0, j = 8; i < arr.Length; i++, j += 80)
            {
                arr[i] = new Layout(Ship);
                arr[i].Pic.Location = new System.Drawing.Point(j, 0);
                //arr[i].Right();

                Panel.Controls.Add(arr[i].Pic);
            }
        }

        //Creates a new game
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;

            for (int i = 0; i < arr.Length; i++)
                arr[i].Reset();

            Landed_Label.Text = Stopped_Lapel.Text = "0";
        }

        //About the Game
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OVERVIEW OF THE PROJECT:\n Have a number of picture boxes move down a form. If the user clicks on a \n picturebox, move that PictureBox to the top of the screen. Count and display the\n number of times a box is clicked. When a box moves below the bottom of the \n screen, count that box as having “gotten away.” After a specific number of \n boxes getting away, stop the game and allow the user to continue playing or \n exit the program.");
        }

    }
}
