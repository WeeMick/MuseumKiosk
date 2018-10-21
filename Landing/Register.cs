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
    public partial class Register : Form
    {
        Keyboard keyboard;
        Numberpad numberpad;
        Help help;
        Home home;
        Form1 form1 = new Form1();
        

        public Register()
        {
            InitializeComponent();
        }

        private void textBox_GotFocus(Object sender, EventArgs e)
        {

            if (numberpad != null)
            {
                numberpad.Close();
            }

            TextBox tb = (TextBox)sender;  // take a copy of the object reference for the particular textbox pressed

            //label3.Text = "TextBox " + tb.Name  + " GotFocus " + DateTime.Now.ToString();  // just some debugging to see which textbox has focus

            if (keyboard == null)  // check if the keyboard is already created
            {
                keyboard = new Keyboard();   // no keyboard so create an instance of one
                keyboard.FormClosed += delegate
                {
                    keyboard = null;  // when the keyboard is closed, dispose of the keyboard instance
                    this.ActiveControl = label1; // when the keyboard is closed, reset focus to the dummy label else
                                                 // it will give focus to a textbox which would trigger the event to
                                                 // make another keyboard appear.
                    tb.BackColor = Color.White;
                    checkTextBoxes();
                };
            }
            
            keyboard.setTextBoxForOutput(tb);  // tell the keyboard which textbox to send its characters too
            keyboard.Show(); // show the keyboard
            tb.BackColor = Color.Gray;

            keyboard.Left = this.Left + tb.Left;  // re-position the keyboard form to be next to
            keyboard.Top = this.Top + tb.Top + tb.Height + 35;    // the textbox that recieves its input.
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;    // when the form loads, direct focus to a label so that a textbox 
                                            // doesn't get focus by default and trigger the GotFocus event (which
                                            // would show the keyboard before we needed it)

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void finnishButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true && checkBox6.Checked == true)
            {
                MessageBox.Show("***** THANK YOU *****\n\nWe have sent a confirmation message to " + mobileTextBox.Text + " with details of the workshop");
                this.Close();
            }
            else
            {
                MessageBox.Show("You need to complete all fields marked with an *");
            }

        }

        private void mobileTextBox_GotFocus(object sender, EventArgs e)
        {
            TextBox nb = (TextBox)sender;  // take a copy of the object reference for the particular textbox pressed

            if (keyboard != null)
            {
                keyboard.Close();
            }

            if (numberpad == null)
            {
                numberpad = new Numberpad();
                numberpad.FormClosed += delegate
                {
                    numberpad = null;
                    this.ActiveControl = label1;
                    nb.BackColor = Color.White;
                    checkNumberBoxes();
                };
            }

            numberpad.setTextBoxForOutput(nb);  // tell the keyboard which textbox to send its characters too
            numberpad.Show(); // show the numberpad
            nb.BackColor = Color.Gray;

            
            numberpad.Left = this.Left + nb.Left;  // re-position the numberpad form to be next to
            numberpad.Top = this.Top + nb.Top + nb.Height + 35;    // the textbox that recieves its input.
            
        }

        public void checkTextBoxes()
        {
            if (nameTextBox.Text != "")
            {
                checkBox1.Checked = true;      
            }
            else
            {
                checkBox1.Checked = false;
            }

           
        }

        public void checkNumberBoxes()
        {
            if (mobileTextBox.Text != "")
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox4.Checked = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
        }

        private void textBox_GotFocus(object sender, MouseEventArgs e)
        {

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            checkBox5.Checked = true;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox6.Checked = true;
        }
    }
}
