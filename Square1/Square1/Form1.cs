﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int side = int.Parse(textBox1.Text);
            int p = side * 4;
            label3.Text = p.ToString() + "cm";           
            int f = side * side;
            label5.Text = f.ToString() + "cm";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
