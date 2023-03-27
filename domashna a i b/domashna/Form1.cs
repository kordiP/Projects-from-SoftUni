using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domashna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           int chislo=int.Parse(textBox1.Text);
           int chislo2=int.Parse(textBox2.Text);
           
       
            int x = chislo;
            chislo = chislo2;
            chislo2 = x;

            label6.Text = chislo.ToString();
            label7.Text = chislo2.ToString();

        
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
