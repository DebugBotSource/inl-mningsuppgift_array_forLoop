using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inlämningsuppgift_array_forLoop
{
    public partial class Form1 : Form
    {
        TextBox[] förstaKolumnen;
        TextBox[] andraKolumnen;

        public Form1()
        {
            InitializeComponent();
            förstaKolumnen = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13 };
            andraKolumnen = new TextBox[] { textBox14, textBox15, textBox16, textBox17, textBox18, textBox19, textBox20, textBox21, textBox22, textBox23, textBox24, textBox25, textBox26 };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < förstaKolumnen.Length; i++)
            {
                förstaKolumnen[i].Clear();
                förstaKolumnen[i].BackColor = default(Color);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            double antalX = 0;
            double antal1 = 0;
            double antal2 = 0;
            string slump = null;
            Random r = new Random();
            for (int i = 0; i < förstaKolumnen.Length; i++)
            {
                slump = r.Next(1, 4).ToString();
                if (slump == "3")
                {
                    slump = "X";
                }
                förstaKolumnen[i].Text = slump;

                if (förstaKolumnen[i].ToString() == andraKolumnen[i].ToString())
                {
                    
                    label3.Text = (int.Parse(label3.Text) + 1).ToString();
                    förstaKolumnen[i].BackColor = Color.Green;
                }
                else förstaKolumnen[i].BackColor = Color.Red;

                if (slump == "X")
                {
                    antalX++;
                }
                if (slump == "1")
                {
                    antal1++;
                }
                if (slump == "2")
                {
                    antal2++;
                }
            }

           
            antal1 = (double)antal1 / 13;
            antal1 = (double)antal1 * 100;
            textBox27.Text = Math.Round(antal1, 1).ToString();

            antalX = (double)antalX / 13;
            antalX = (double)antalX * 100;
            textBox28.Text = Math.Round(antalX, 1).ToString();

            antal2 = (double)antal2 / 13;
            antal2 = (double)antal2 * 100;
            textBox29.Text = Math.Round(antal2, 1).ToString();
            
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        //----------------Följande är alla metoder----------------//


    }
}
