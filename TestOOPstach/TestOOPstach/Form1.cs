using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOOPstach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }
        bool muzu = false;

        int oblicejcislo;
        int vlasy;
        int barvavlasu;
        Hrac radek;
        private void button2_Click(object sender, EventArgs e)
        {
            radek = new Hrac(textBox1.Text, textBox2.Text, oblicejcislo, vlasy, barvavlasu);
            label1.Text = radek.ToString();
            muzu = true;
            button1.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            oblicejcislo = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            oblicejcislo = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            oblicejcislo = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            vlasy = 0;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            vlasy = 1;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            vlasy = 2;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            barvavlasu = 0;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            barvavlasu = 1;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            barvavlasu = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radek.PridejXP((int)numericUpDown1.Value);
            label1.Text = radek.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }


        int prace;
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            prace = 0;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            prace = 1;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            prace = 2;
        }
        bool sila;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                sila = true;
            }
            else { sila = false; }
        }

        NPC npccko;
        private void button3_Click(object sender, EventArgs e)
        {
            npccko = new NPC(textBox4.Text, prace, sila);
            label6.Text = npccko.ToString();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int a = MousePosition.X;
            int b = MousePosition.Y;
            if (muzu == true)
            {
                radek.zmenaPozice(a, b);
                radek.ToString();
            }
        }
    }
}
