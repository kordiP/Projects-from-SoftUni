using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox4.Text);
            int b = int.Parse(textBox5.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox2.Text);
            c = c * 100;
            d = d * 100;
            double p = (double)c / a;
            double q = (double)d / b;
            double x = Math.Ceiling(p);
            double y = Math.Ceiling(q);
            textBox1.Text = (x * y).ToString();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
