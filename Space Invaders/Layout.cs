using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing;



namespace Space_Invaders
{
    class Layout
    {
        public PictureBox Pic;
        public bool Landed;
        public int Clicked;

        

        public Layout(int Ship)
        {
            Pic = new PictureBox();
            Pic.Click += new EventHandler(Pic_Click);
            
            Pic.SizeMode = PictureBoxSizeMode.AutoSize;
            //Pic.Size = new Size(35, 38);

            if (Ship == 1)
                Pic.Image = Properties.Resources.Default;

            else if (Ship == 2)
                Pic.Image = Properties.Resources.Blue;

            else
                Pic.Image = Properties.Resources.Red;

            Landed = false;
            Clicked = 0;

        }

        private void Pic_Click(object sender, EventArgs e)
        {
            Pic.Top = 0;
            Clicked++;
        }

        public void Right()
        {
            Image img = Pic.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Pic.Image = img;
        }

        public void Left()
        {
            Image img = Pic.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            Pic.Image = img;
        }

        public void Reset()
        {
            Pic.Show();
            Landed = false;
            Pic.Top = 0;
            Clicked = 0;
        }

        public void Ship(int Ship)
        {
            if (Ship == 1)
                Pic.Image = Properties.Resources.Default;

            else if (Ship == 2)
                Pic.Image = Properties.Resources.Blue;

            else
                Pic.Image = Properties.Resources.Red;

            Pic.SizeMode = PictureBoxSizeMode.AutoSize;
        }

    }

}
