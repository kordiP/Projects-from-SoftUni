﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var i = double.Parse(textBox1.Text);
            var u = double.Parse(textBox2.Text);
            var suma = i + u;
            label1.Text = suma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var i = double.Parse(textBox1.Text);
            var u = double.Parse(textBox2.Text);
            var suma = i - u;
            label1.Text = suma.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var i = double.Parse(textBox1.Text);
            var u = double.Parse(textBox2.Text);
            var suma = i * u;
            label1.Text = suma.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var i = int.Parse(textBox1.Text);
            var u = int.Parse(textBox2.Text);
            var suma = i / u;
            label1.Text = suma.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var i = int.Parse(textBox1.Text);
            var u = int.Parse(textBox2.Text);
            var suma = i % u;
            label1.Text = suma.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";
        }
    }
}
