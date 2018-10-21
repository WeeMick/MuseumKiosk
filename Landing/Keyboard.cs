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
    public partial class Keyboard : Form
    {
        TextBox tt;

        public Keyboard()
        {
            InitializeComponent();
            this.TopMost = true;  // make the keyboard always in front of the other forms
        }

        public void setTextBoxForOutput(TextBox t)
        {
            tt = t;  // 
        }

        private void button_Click(object sender, EventArgs e)
        {

            tt.Text += ((Button)sender).Text;
        }

        String textEntry = "";



            private void QKey_MouseDown(object sender, MouseEventArgs e)
        {
            QKey.BackColor = Color.Green;
            textEntry = textEntry + "Q";
            tt.Text = textEntry;
        }

        private void QKey_MouseUp(object sender, MouseEventArgs e)
        {
            QKey.BackColor = Color.Black;
        }

        private void WKey_MouseDown(object sender, MouseEventArgs e)
        {
            WKey.BackColor = Color.Green;
            textEntry = textEntry + "W";
            tt.Text = textEntry;
        }

        private void WKey_MouseUp(object sender, MouseEventArgs e)
        {
            WKey.BackColor = Color.Black;
        }

        private void EKey_MouseDown(object sender, MouseEventArgs e)
        {
            EKey.BackColor = Color.Green;
            textEntry = textEntry + "E";
            tt.Text = textEntry;
        }

        private void EKey_MouseUp(object sender, MouseEventArgs e)
        {
            EKey.BackColor = Color.Black;
        }

        private void RKey_MouseDown(object sender, MouseEventArgs e)
        {
            RKey.BackColor = Color.Green;
            textEntry = textEntry + "R";
            tt.Text = textEntry;
        }

        private void RKey_MouseUp(object sender, MouseEventArgs e)
        {
            RKey.BackColor = Color.Black;
        }

        private void TKey_MouseDown(object sender, MouseEventArgs e)
        {
            TKey.BackColor = Color.Green;
            textEntry = textEntry + "T";
            tt.Text = textEntry;
        }

        private void TKey_MouseUp(object sender, MouseEventArgs e)
        {
            TKey.BackColor = Color.Black;
        }

        private void YKey_MouseDown(object sender, MouseEventArgs e)
        {
            YKey.BackColor = Color.Green;
            textEntry = textEntry + "Y";
            tt.Text = textEntry;
        }

        private void YKey_MouseUp(object sender, MouseEventArgs e)
        {
            YKey.BackColor = Color.Black;
        }

        private void UKey_MouseDown(object sender, MouseEventArgs e)
        {
            UKey.BackColor = Color.Green;
            textEntry = textEntry + "U";
            tt.Text = textEntry;
        }

        private void UKey_MouseUp(object sender, MouseEventArgs e)
        {
            UKey.BackColor = Color.Black;
        }

        private void IKey_MouseDown(object sender, MouseEventArgs e)
        {
            IKey.BackColor = Color.Green;
            textEntry = textEntry + "I";
            tt.Text = textEntry;
        }

        private void IKey_MouseUp(object sender, MouseEventArgs e)
        {
            IKey.BackColor = Color.Black;
        }

        private void OKey_MouseDown(object sender, MouseEventArgs e)
        {
            OKey.BackColor = Color.Green;
            textEntry = textEntry + "O";
            tt.Text = textEntry;
        }

        private void OKey_MouseUp(object sender, MouseEventArgs e)
        {
            OKey.BackColor = Color.Black;
        }
        private void PKey_MouseDown(object sender, MouseEventArgs e)
        {
            PKey.BackColor = Color.Green;
            textEntry = textEntry + "P";
            tt.Text = textEntry;
        }

        private void PKey_MouseUp(object sender, MouseEventArgs e)
        {
            PKey.BackColor = Color.Black;
        }

        private void AKey_MouseDown(object sender, MouseEventArgs e)
        {
            AKey.BackColor = Color.Green;
            textEntry = textEntry + "A";
            tt.Text = textEntry;
        }

        private void AKey_MouseUp(object sender, MouseEventArgs e)
        {
            AKey.BackColor = Color.Black;
        }

        private void SKey_MouseDown(object sender, MouseEventArgs e)
        {
            SKey.BackColor = Color.Green;
            textEntry = textEntry + "S";
            tt.Text = textEntry;
        }

        private void SKey_MouseUp(object sender, MouseEventArgs e)
        {
            SKey.BackColor = Color.Black;
        }

        private void DKey_MouseDown(object sender, MouseEventArgs e)
        {
            DKey.BackColor = Color.Green;
            textEntry = textEntry + "D";
            tt.Text = textEntry;
        }

        private void DKey_MouseUp(object sender, MouseEventArgs e)
        {
            DKey.BackColor = Color.Black;
        }

        private void FKey_MouseDown(object sender, MouseEventArgs e)
        {
            FKey.BackColor = Color.Green;
            textEntry = textEntry + "F";
            tt.Text = textEntry;
        }

        private void FKey_MouseUp(object sender, MouseEventArgs e)
        {
            FKey.BackColor = Color.Black;
        }

        private void GKey_MouseDown(object sender, MouseEventArgs e)
        {
            GKey.BackColor = Color.Green;
            textEntry = textEntry + "G";
            tt.Text = textEntry;
        }

        private void GKey_MouseUp(object sender, MouseEventArgs e)
        {
            GKey.BackColor = Color.Black;
        }

        private void HKey_MouseDown(object sender, MouseEventArgs e)
        {
            HKey.BackColor = Color.Green;
            textEntry = textEntry + "H";
            tt.Text = textEntry;
        }

        private void HKey_MouseUp(object sender, MouseEventArgs e)
        {
            HKey.BackColor = Color.Black;
        }

        private void JKey_MouseDown(object sender, MouseEventArgs e)
        {
            JKey.BackColor = Color.Green;
            textEntry = textEntry + "J";
            tt.Text = textEntry;
        }

        private void JKey_MouseUp(object sender, MouseEventArgs e)
        {
            JKey.BackColor = Color.Black;
        }

        private void KKey_MouseDown(object sender, MouseEventArgs e)
        {
            KKey.BackColor = Color.Green;
            textEntry = textEntry + "K";
            tt.Text = textEntry;
        }

        private void KKey_MouseUp(object sender, MouseEventArgs e)
        {
            KKey.BackColor = Color.Black;
        }

        private void LKey_MouseDown(object sender, MouseEventArgs e)
        {
            LKey.BackColor = Color.Green;
            textEntry = textEntry + "L";
            tt.Text = textEntry;
        }

        private void LKey_MouseUp(object sender, MouseEventArgs e)
        {
            LKey.BackColor = Color.Black;
        }

        private void ZKey_MouseDown(object sender, MouseEventArgs e)
        {
            ZKey.BackColor = Color.Green;
            textEntry = textEntry + "Z";
            tt.Text = textEntry;
        }

        private void ZKey_MouseUp(object sender, MouseEventArgs e)
        {
            ZKey.BackColor = Color.Black;
        }

        private void XKey_MouseDown(object sender, MouseEventArgs e)
        {
            XKey.BackColor = Color.Green;
            textEntry = textEntry + "X";
            tt.Text = textEntry;
        }

        private void XKey_MouseUp(object sender, MouseEventArgs e)
        {
            XKey.BackColor = Color.Black;
        }

        private void CKey_MouseDown(object sender, MouseEventArgs e)
        {
            CKey.BackColor = Color.Green;
            textEntry = textEntry + "C";
            tt.Text = textEntry;
        }

        private void CKey_MouseUp(object sender, MouseEventArgs e)
        {
            CKey.BackColor = Color.Black;
        }

        private void VKey_MouseDown(object sender, MouseEventArgs e)
        {
            VKey.BackColor = Color.Green;
            textEntry = textEntry + "V";
            tt.Text = textEntry;
        }

        private void VKey_MouseUp(object sender, MouseEventArgs e)
        {
            VKey.BackColor = Color.Black;
        }

        private void BKey_MouseDown(object sender, MouseEventArgs e)
        {
            BKey.BackColor = Color.Green;
            textEntry = textEntry + "B";
            tt.Text = textEntry;
        }

        private void BKey_MouseUp(object sender, MouseEventArgs e)
        {
            BKey.BackColor = Color.Black;
        }

        private void NKey_MouseDown(object sender, MouseEventArgs e)
        {
            NKey.BackColor = Color.Green;
            textEntry = textEntry + "N";
            tt.Text = textEntry;
        }

        private void NKey_MouseUp(object sender, MouseEventArgs e)
        {
            NKey.BackColor = Color.Black;
        }

        private void MKey_MouseDown(object sender, MouseEventArgs e)
        {
            MKey.BackColor = Color.Green;
            textEntry = textEntry + "M";
            tt.Text = textEntry;
        }

        private void MKey_MouseUp(object sender, MouseEventArgs e)
        {
            MKey.BackColor = Color.Black;
        }

        private void Space_MouseDown(object sender, MouseEventArgs e)
        {
            Space.BackColor = Color.Green;
            textEntry += " ";
            tt.Text = textEntry;
            Space.BackColor = Color.Green;
        }

        private void Space_MouseUp(object sender, MouseEventArgs e)
        {
            Space.BackColor = Color.Black;
        }

        private void delete_MouseDown(object sender, EventArgs e)
        {
            delete.BackColor = Color.Green;
            if (tt.Text.Length > 0)
            {
                textEntry = tt.Text.Substring(0, tt.Text.Length - 1);
                tt.Text = textEntry;
            }
            else
            {
                delete.BackColor = Color.White; // gives feedback to user that nothing more can be deleted
                
            }
        }

        private void delete_MouseUp(object sender, MouseEventArgs e)
        {
            delete.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hyphenButton_MouseDown(object sender, MouseEventArgs e)
        {
            hyphenButton.BackColor = Color.Green;
                textEntry = textEntry + "-";
                tt.Text = textEntry;
            }

            private void hyphenButton_MouseUp(object sender, MouseEventArgs e)
            {
                hyphenButton.BackColor = Color.Black;
            }

        private void otherE_MouseDown(object sender, MouseEventArgs e)
        {
            otherE.BackColor = Color.Green;
            textEntry = textEntry + "É";
            tt.Text = textEntry;
        }

        private void otherE_MouseUp(object sender, MouseEventArgs e)
        {
            otherE.BackColor = Color.Black;
        }

        private void otherN_MouseDown(object sender, MouseEventArgs e)
        {
            otherN.BackColor = Color.Green;
            textEntry = textEntry + "Ñ";
            tt.Text = textEntry;
        }

        private void otherN_MouseUp(object sender, MouseEventArgs e)
        {
            otherN.BackColor = Color.Black;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Green;
            textEntry = textEntry + "'";
            tt.Text = textEntry;
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Black;
        }
    }


}


