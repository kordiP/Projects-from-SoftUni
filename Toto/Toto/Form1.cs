using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toto
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            textBox1.Text = GetRandNumber().ToString();
            textBox2.Text = GetRandNumber().ToString();
            textBox3.Text = GetRandNumber().ToString();
            textBox4.Text = GetRandNumber().ToString();
            textBox5.Text = GetRandNumber().ToString();
            textBox6.Text = GetRandNumber().ToString();
        }

    int GetRandNumber()
        {
            return r.Next() % 49 + 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
