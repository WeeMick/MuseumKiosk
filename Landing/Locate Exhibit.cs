using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Landing
{
    public partial class Locate_Exhibit : Form
    {
        Home home;
        Image imgOriginal;
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        Help help;
        //Form1 form1 = new Form1();
        public Locate_Exhibit()
        {
            InitializeComponent();
            speechButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        Image Zoom(Image img, Size size)
        {
            
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 10), img.Height + (img.Height * size.Height / 10));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value > 0)
            {
                pictureBox1.Image = Zoom(imgOriginal, new Size(trackBar1.Value/5, trackBar1.Value/5));
            }
        }

        private void Locate_Exhibit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Dispose();
        }

        private void Locate_Exhibit_Load(object sender, EventArgs e)
        {
            imgOriginal = pictureBox1.BackgroundImage;
        }

        private void resetImageButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("..\\..\\..\\Images\\map.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void speechButton_Click(object sender, EventArgs e)
        {
            PromptBuilder builder = new PromptBuilder();
            builder.AppendText(speechTextBox.Text);
            synthesizer.Speak(builder);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            home = new Home();
            home.Show();
            this.Close();
        }

        private void helpButton4_Click(object sender, EventArgs e)
        {
            help = new Help();
            help.Show();
        }
    }
}
