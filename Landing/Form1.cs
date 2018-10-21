using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landing
{
    public partial class Form1 : Form
    {
        Home home = new Home();

        public Form1()
        {
            InitializeComponent();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            home = new Home();
            home.Show();
            this.Hide();
            resetI();
        }

        private void InitializeTimer()
        {
            // Run this procedure in an appropriate event.  
            timer1.Start();

            timer1.Enabled = true;
            // Hook up timer's tick event handler.  
            timer1.Tick += new EventHandler(timer1_Tick);
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        public int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            i++;
            //textBox1.Text = i.ToString();
            if (i % 2 == 0)
            {
                pictureBox2.Image = Image.FromFile("..\\..\\..\\Images\\handup.png");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox2.Image = Image.FromFile("..\\..\\..\\Images\\handdown.png");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
           
        }

        public void resetI()
        {
            i = 0;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            home.Show();
            this.Hide();
        }

    }
}
