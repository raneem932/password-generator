using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      Random random = new Random();

        private void generateKey(object sender, EventArgs e,int length)
        {
            length = trbCharactersRan.Value;
            Random random = new Random();
            string character = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&><*()_+=";
            string all = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&><*()_+=1234567890";
            string number = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder password = new StringBuilder();
            if (chbnumbers.Checked == true && chbsymbols.Checked == false) {
                for (int i = 0; i < length; i++) {
                    int index = random.Next(number.Length);
                    password.Append(number[index]);
                    txbGeneratedPassword.Text = password.ToString(); 
                }
            }
            else if(chbnumbers.Checked == false && chbsymbols.Checked == false)
            {
                for (int i = 0; i < length; i++)
                {
                    int index = random.Next(character.Length);
                    password.Append(character[index]);
                    txbGeneratedPassword.Text = password.ToString();
                }
            }
            else if(chbnumbers.Checked == false && chbsymbols.Checked == true)
            {
                for (int i = 0; i < length; i++)
                {
                    int index = random.Next(symbols.Length);
                    password.Append(symbols[index]);
                    txbGeneratedPassword.Text = password.ToString();
                }
            }
            else if (chbnumbers.Checked == true && chbsymbols.Checked == true)
            {
                for (int i = 0; i < length; i++)
                {
                    int index = random.Next(all.Length);
                    password.Append(all[index]);
                    txbGeneratedPassword.Text = password.ToString();
                }
            }
        }
        private void generatePinPassword()
        {
            StringBuilder password = new StringBuilder();
            string pinNumbers = "1234567890";
            for (int i = 0; i < trbpin.Value; i++)
            {
                int index = random.Next(pinNumbers.Length);
                password.Append(pinNumbers[index]);
                txbpin.Text = password.ToString();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           int length = trbCharactersRan.Value;
            generateKey(sender, e, trbCharactersRan.Value   );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trbpin.Value = 10;
            trbCharactersRan.Value = 10;
            int length = trbCharactersRan.Value;
            generateKey(sender, e, trbCharactersRan.Value);
            generatePinPassword();
        }

        private void trbCharactersRan_Scroll(object sender, ScrollEventArgs e)
        {
            generateKey(sender, e, trbCharactersRan.Value);
            int length = trbCharactersRan.Value;
        }

        private void rdSymbols_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            generateKey(sender, e, trbCharactersRan.Value);
            int length = trbCharactersRan.Value;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done", "copy");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            generatePinPassword();

        }

        private void trbpin_Scroll(object sender, ScrollEventArgs e)
        {
            generatePinPassword();
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            generatePinPassword();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chbnumbers.Checked = true;
            generateKey(sender, e, trbCharactersRan.Value);
            int length = trbCharactersRan.Value;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            chbsymbols.Checked = true;
            generateKey(sender, e, trbCharactersRan.Value);
            int length = trbCharactersRan.Value;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txbGeneratedPassword.FillColor=colorDialog1.Color;
            }
        }

        private void txbGeneratedPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
       
            fontDialog1.ShowColor = true;
            fontDialog1.ShowApply = true;
            fontDialog1.ShowEffects = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txbGeneratedPassword.Font=fontDialog1.Font;
                txbGeneratedPassword.ForeColor = fontDialog1.Color;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            txbGeneratedPassword.Font = fontDialog1.Font;
            txbGeneratedPassword.ForeColor = fontDialog1.Color;
        }
    }
}
