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
    public partial class Search_Via_Text : Form
    {
        Keyboard keyboard;
        private Button button1;
        private Label label2;
        private Label label1;
        TextSearchResults textResults;
        Home home;
        Help help;
        private string n;
        //Form1 form1 = new Form1();

        public Search_Via_Text()
        {
            InitializeComponent();
        }

        private void textBox_GotFocus(Object sender, EventArgs e)
        {

            TextBox tb = (TextBox)sender;  // take a copy of the object reference for the particular textbox pressed

            //label3.Text = "TextBox " + tb.Name + " GotFocus " + DateTime.Now.ToString();  // just some debugging to see which textbox has focus

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
            this.ActiveControl = button1;    // when the form loads, direct focus to a label so that a textbox 
                                             // doesn't get focus by default and trigger the GotFocus event (which
                                             // would show the keyboard before we needed it)
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (textExhibit.Text != "")
            {
                if (textExhibit.Text.Equals("Syria", StringComparison.InvariantCultureIgnoreCase))
                {
                    textResults = new TextSearchResults();
                    n = "Syria: A Conflict Explored";
                    textResults.setExhibit(n);
                    textResults.setPicture();
                    textResults.Show();
                    textResults.label2.Text = n;
                }
                else if (textExhibit.Text.Equals("Wyndham", StringComparison.InvariantCultureIgnoreCase))
                {
                    textResults = new TextSearchResults();
                    n = "Wyndham: Art, Life, War";
                    textResults.setExhibit(n);
                    textResults.setPicture();
                    textResults.Show();
                    textResults.label2.Text = n;
                }
                else if (textExhibit.Text.Equals("Main", StringComparison.InvariantCultureIgnoreCase))
                {
                    textResults = new TextSearchResults();
                    n = "Main Exhibition Space";
                    textResults.setExhibit(n);
                    textResults.setPicture();
                    textResults.Show();
                    textResults.label2.Text = "Main Exhibition Space";
                }
                else if (textExhibit.Text.Equals("Big", StringComparison.InvariantCultureIgnoreCase))
                {
                    textResults = new TextSearchResults();
                    n = "Big Picture Show";
                    textResults.setExhibit(n);
                    textResults.setPicture();
                    textResults.Show();
                    textResults.label2.Text = "Big Picture Show";
                }
                else if (textExhibit.Text.Equals("Mixing it", StringComparison.InvariantCultureIgnoreCase))
                {
                    textResults = new TextSearchResults();
                    n = "Mixing It: The Changing Faces of Wartime Britain";
                    textResults.setExhibit(n);
                    textResults.setPicture();
                    textResults.Show();
                    textResults.label2.Text = "Mixing it";
                }
                else if (textExhibit.Text.Equals("Architecture", StringComparison.InvariantCultureIgnoreCase))
                {
                    textResults = new TextSearchResults();
                    n = "Architecture";
                    textResults.setExhibit(n);
                    textResults.setPicture();
                    textResults.Show();
                    textResults.label2.Text = "Architecture";
                }
                else
                {
                    MessageBox.Show("We cannot find the exhibit you are looking for");
                }
            }
            else
            {
                MessageBox.Show("You haven't typed any search criteria");
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                goButton.Hide();
                orderByListBox.Show();
                label7.Show();
                label9.Hide();
                listBoxFinal.Hide();
            }
            else
            {
                goButton.Hide();
                orderByListBox.Hide();
                label7.Hide();
                label9.Show();
                label8.Hide();
                dateTimePicker1.Hide();
                listBoxFinal.Items.Clear();
                listBoxFinal.Items.Add("Main Exhibition Space");
                listBoxFinal.Items.Add("Big Picture Show");
                listBoxFinal.Items.Add("Mixing It: The Changing Faces of Wartime Britain");
                listBoxFinal.Items.Add("Architecture");
                listBoxFinal.Show();
            }

        }

        private void orderByListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0 && orderByListBox.SelectedIndex == 0)
            {
                listBoxFinal.Sorted = true;
                label9.Show();
                dateTimePicker1.Hide();
                label8.Hide();
                listBoxFinal.Items.Clear();
                listBoxFinal.Items.Add("Syria: A Conflict Explored");
                listBoxFinal.Items.Add("Wyndham: Art, Life, War");
                listBoxFinal.Show();
                goButton.Hide();
            }

            else if (listBox1.SelectedIndex == 0 && orderByListBox.SelectedIndex == 1)
            {
                dateTimePicker1.Show();
                label8.Show();
                label9.Hide();
                listBoxFinal.Items.Clear();
                listBoxFinal.Hide();
                goButton.Hide();
            }

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date.Month == 3)
            {
                label9.Show();
                listBoxFinal.Items.Clear();
                listBoxFinal.Items.Add("Syria: A Conflict Explored");
                listBoxFinal.Show();
                goButton.Hide();
            }
            else if ( dateTimePicker1.Value.Date.Month == 2)
            {
                label9.Show();
                listBoxFinal.Items.Clear();
                listBoxFinal.Items.Add("Wyndham: Art, Life, War");
                listBoxFinal.Show();
                goButton.Hide();
            }
            else
            {
                goButton.Hide();
                label9.Hide();
                listBoxFinal.Items.Clear();
                listBoxFinal.Hide();
                MessageBox.Show("There are no exhibits closing in this month");

            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            textResults = new TextSearchResults();
            n = listBoxFinal.GetItemText(listBoxFinal.SelectedItem).ToString();
            textResults.setExhibit(n);
            textResults.setPicture();
            textResults.Show();
            textResults.label2.Text = n;
        }

        private void listBoxFinal_SelectedIndexChanged(object sender, EventArgs e)
            
        {
            goButton.Show();
            goButton.Text = "Search for " + listBoxFinal.GetItemText(listBoxFinal.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textExhibit.Visible = false;
            listBox1.Enabled = true;
            listBox1.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            orderByListBox.Enabled = true;
            listBoxFinal.Enabled = true;
            dateTimePicker1.Enabled = true;
            textExhibit.Enabled = false;
            goButton.Enabled = true;
            //searchButton.Enabled = false;
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            searchButton.Visible = false;
            if(keyboard != null)
            {
                keyboard.Close();
            }
        }

        private void textSearch_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textExhibit.Visible = true;
            textExhibit.Enabled = true;
            listBox1.Visible = false;
            goButton.Visible = false;
            orderByListBox.Visible = false;
            listBoxFinal.Visible = false;
            dateTimePicker1.Visible = false;
            //searchButton.Visible = true;
            checkBox2.Checked = false;
            checkBox1.Checked = true;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label7.Visible = false;

        }

        private void textExhibit_TextChanged(object sender, EventArgs e)
        {
            searchButton.Show();
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
