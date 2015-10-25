using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Space_Invader
{
    public partial class Form1 : Form
    {

        int Landed = 0;
        int Stopped = 0;

        public Form1()
        {
            InitializeComponent();

            Landed = 0;
            Stopped = 0;

            pictureBox1.Top = 0;
            pictureBox2.Top = 0;
            pictureBox3.Top = 0;
            pictureBox4.Top = 0;
            pictureBox5.Top = 0;

            Stopped_Lapel.Text = Stopped.ToString();
            Landed_Label.Text = Landed.ToString();
        }


        //Exit the Application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void Timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 20;
            pictureBox2.Top += 20;
            pictureBox3.Top += 20;
            pictureBox4.Top += 20;
            pictureBox5.Top += 20;

            if (pictureBox1.Top >= 290 && pictureBox1.Top <= 310)
            {
                pictureBox1.Hide();
                Landed++;
            }

            if (pictureBox2.Top >= 290 && pictureBox2.Top <= 310)
            {
                pictureBox2.Hide();
                Landed++;
            }

            if (pictureBox3.Top >= 290 && pictureBox3.Top <= 310)
            {
                pictureBox3.Hide();
                Landed++;
            }

            if (pictureBox4.Top >= 290 && pictureBox4.Top <= 310)
            {
                pictureBox4.Hide();
                Landed++;
            }

            if (pictureBox5.Top >= 290 && pictureBox5.Top <= 310)
            {
                pictureBox5.Hide();
                Landed++;
            }


            if (Landed == 5)
                Timer.Enabled = false;

            Landed_Label.Text = Landed.ToString();
            

        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        //sets the Difficulty

        private void lowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer.Interval = 1000;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer.Interval = 500;
        }

        private void highToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer.Interval = 250;
        }

        //Click Events for each Picture box

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Stopped++;
            pictureBox1.Top = 0;
            Stopped_Lapel.Text = Stopped.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Stopped++;
            pictureBox2.Top = 0;
            Stopped_Lapel.Text = Stopped.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Stopped++;
            pictureBox3.Top = 0;
            Stopped_Lapel.Text = Stopped.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Stopped++;
            pictureBox4.Top = 0;
            Stopped_Lapel.Text = Stopped.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Stopped++;
            pictureBox5.Top = 0;
            Stopped_Lapel.Text = Stopped.ToString();
        }


        //Creates a new game
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Landed = 0;
            Stopped = 0;

            pictureBox1.Top = 0;
            pictureBox2.Top = 0;
            pictureBox3.Top = 0;
            pictureBox4.Top = 0;
            pictureBox5.Top = 0;

            Stopped_Lapel.Text = Stopped.ToString();
            Landed_Label.Text = Landed.ToString();
        }


        //Pause the Application
        private void Pause_Button_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
        }

        //Restart the Application
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
