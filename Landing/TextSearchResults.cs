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
    public partial class TextSearchResults : Form
    {
        
        public String exhibit;
        public String speech;
        Help help;
        Home home;
        //Form1 form1 = new Form1();
        
        public TextSearchResults()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newSearchButton_Click(object sender, EventArgs e)
        {
            Search_Via_Text newSearch = new Search_Via_Text();
            newSearch.Show();
        }

        private void locateExhibit_Click(object sender, EventArgs e)
        {
            Locate_Exhibit locate = new Locate_Exhibit();
            locate.speechTextBox.Text = speech;
            locate.Show();
        }


        public void setExhibit(String k)
        {
            exhibit = k;
        }


        public void setPicture()
        {
            if (exhibit.Equals("Syria: A Conflict Explored"))
            
            {
                resultsPictureBox.Image = Image.FromFile("..\\..\\..\\Images\\Syria.png");
                resultsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                descBox.Text = "Gain an understanding of the origins, escalations and human impact of the ongoing Syria conflict in Syria: A Conflict Explored, a season of exhibitions and events — part of our Conflict Now programming strand.";
                speech = "Syria: A Conflict Explored, is located on the ground floor";
            }

            else if (exhibit.Equals("Wyndham: Art, Life, War"))
            {
                resultsPictureBox.Image = Image.FromFile("..\\..\\..\\Images\\Wyndham.png");
                resultsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                descBox.Text = "It's your last chance to visit Wyndham Lewis: Life, Art, War before the exhibition closes on 1 January 2018. Discover the artworks and story of Britain’s original rebel artist in the largest UK retrospective of Wyndham Lewis’ work to date";
                speech = "Wyndham: Art, Life, War, can be found on the first floor";
            }
            else if (exhibit.Equals("Main Exhibition Space"))
            {
                resultsPictureBox.Image = Image.FromFile("..\\..\\..\\Images\\MAin Exhibition.png");
                resultsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                descBox.Text = "Our striking Main Exhibition Space features a timeline of the conflicts that Britain and the Commonwealth have been involved in since the First World War.";
                speech = "The Main Exhibition Space can be found in the room behind the reception";
            }
            else if (exhibit.Equals("Big Picture Show"))
            {
                resultsPictureBox.Image = Image.FromFile("..\\..\\..\\\\Images\\Big Picture.png");
                resultsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                descBox.Text = "Using surround sound, projected digital moving images and photographs, the Big Picture Show brings to life people’s experiences of war.";
                speech = "The Big Picture Show is showing in the second floor theatre";
            }
            else if (exhibit.Equals("Mixing It: The Changing Faces of Wartime Britain"))
            {
                resultsPictureBox.Image = Image.FromFile("..\\..\\..\\\\Images\\Mixing it.png");
                resultsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                descBox.Text = "Mixing It: The Changing Faces of Wartime Britain reveals the forgotten histories of service personnel and civilians who came to Britain during the Second World War – a time when the national and ethnic diversity of the population was unpreced";
                speech = "Mixing It: The Changing Faces of Wartime Britain is displayed at the left-hand side of the ground floor";
            }
            else if (exhibit.Equals("Architecture"))
            {
                resultsPictureBox.Image = Image.FromFile("..\\..\\..\\\\Images\\Architecture.png");
                resultsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                descBox.Text = "WM North is housed in a striking, aluminium clad building – the first in the UK to be designed by internationally acclaimed architect Daniel Libeskind.";
                speech = "The architecture exhibit is located on the right-hand side of the first floor";
            }
            else
            {
                resultsPictureBox.Image = Image.FromFile("..\\..\\..\\\\Images\\Reactions.png");
                resultsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                descBox.Text = "At IWM North, we've been commissioning high-quality artworks, events, workshops and live performances from contemporary artists since 2010";
                speech = "You have not selected an exhibit to locate";
            }
            
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
