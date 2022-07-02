using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ok_I_need_names
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string s, s1, s2;
            s = "The Email for Ivo Kolev is kolev@kolev.com";
            int  d1, d2, d3;
            s1 = "kolev";
                s2 = "KOLEV";
            d1 = s.IndexOf(s1);
            d2 = s.LastIndexOf(s1);
            d3 = s.LastIndexOf(s2);
            label1.Text = d1.ToString();
            label2.Text = d2.ToString();
            label3.Text = d3.ToString();



            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
