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
    public partial class Numberpad : Form
    {
        TextBox tt;
        
        public Numberpad()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        public void setTextBoxForOutput(TextBox t)
        {
            tt = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1 = (Button)sender;
            tt.Text += button1.Text;
        }


        private void Numberpad_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
         
                button1 = (Button)sender;
                tt.Text += button1.Text;
                button1.BackColor = Color.Green;
            
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void deleteButton_MouseDown(object sender, MouseEventArgs e)
        {
            deleteButton.BackColor = Color.Green;
            if (tt.Text.Length > 0)
            {
                tt.Text = tt.Text.Substring(0, tt.Text.Length - 1);
                
            }
            else
            {
                deleteButton.BackColor = Color.White; // gives feedback to user that nothing more can be deleted

            }
        }

        private void deleteButton_MouseUp(object sender, MouseEventArgs e)
        {
            deleteButton.BackColor = Color.Black;
        }
    }
}
