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
    public partial class Home : Form
    {
        Search_Via_Text search;
        Locate_Exhibit locate = new Locate_Exhibit();
        Register register;
        Help help;
        Form1 form1;




        public Home()
             
        {
            //this.form1 = parent;
            InitializeComponent();
            
        }

        private void SearchExhibitButton_Click(object sender, EventArgs e)
        {
            search = new Search_Via_Text();
            search.Show();
            
        }

        private void LocateExhibitButton_Click(object sender, EventArgs e)
        {
            locate.Show();
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            register = new Register();
            register.Show();
            
        }



        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void helpButton4_Click(object sender, EventArgs e)
        {
            help = new Help();
            help.Show();
        }

     
    }
}
