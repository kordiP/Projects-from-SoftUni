using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int suma;
            int ed = x % 10;
            int des = x / 10 % 10;
            int sto = x / 100;
            suma = ed + des + sto;
            label1.Text = suma.ToString();

        }
    }
}
