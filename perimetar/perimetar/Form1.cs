using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perimetar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double side = double.Parse(textBox1.Text);
            double side2 = double.Parse(textBox2.Text);
            double P = side + side2+side + side2;
            label3.Text = P.ToString();
        }
    }
}
