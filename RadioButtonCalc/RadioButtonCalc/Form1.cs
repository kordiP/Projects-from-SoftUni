using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonCalc
{
    public partial class Form1 : Form
    {
        int otgovor;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Izhod_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void plus_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void minus_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            otgovor = a - b;
        }

        private void umnojenie_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            otgovor = a * b;
        }

        private void delenie_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            if (b!=0)
            {
                otgovor = a / b;
            }
            else
            {
                textBox1.Text = "Не се дели на 0!";
            }

        }

        private void ostatuk_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            if (b!=0)
            {
                otgovor = a % b;
            }
            else
            {
                textBox1.Text = "Не се дели на 0!";
            }
        }

        private void presmetni_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = otgovor.ToString();
        }

        private void Izchisti_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";

        }

        private void subirane_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            otgovor = a + b;
        }
    }
}
