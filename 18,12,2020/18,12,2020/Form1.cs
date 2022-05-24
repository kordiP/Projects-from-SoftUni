using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_12_2020
{
    public partial class Form1 : Form
    {
        double kafePL = 0.40;
        double kafeSF = 0.50;
        double kafeVR = 0.45;
        double vodaPL = 0.70;
        double vodaSF = 0.80;
        double vodaVR = 0.75;
        double biraPL = 1.15;
        double biraSF = 1.20;
        double biraVR = 1.10;
        double fustukPL = 1.50;
        double fustukSF = 1.60;
        double fustukVR = 1.55;
        double bonbonPL = 1.30;
        double bonbonSF = 1.45;
        double bonbonVR = 1.35;
        string grad;
        string produkt;
        public Form1()
        {
            InitializeComponent();
            
        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            //софия
            label5.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label4.Visible = false;
            button9.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Text = "Кафе - 0,50 лв."; 
            button5.Text = "Вода - 0,80 лв.";
            button6.Text = "Бира - 1,20 лв.";
            button7.Text = "Фъстъци - 1,60 лв.";
            button8.Text = "Бонбони - 1,45 лв.";
            grad = "S";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //варна
            label5.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label4.Visible = false;
            button9.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Text = "Кафе - 0,45 лв.";
            button5.Text = "Вода - 0,75 лв.";
            button6.Text = "Бира - 1,10 лв.";
            button7.Text = "Фъстъци - 1,55 лв.";
            button8.Text = "Бонбони - 1,35 лв.";
            grad = "V";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //пловдив
            label5.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label4.Visible = false;
            button9.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Text = "Кафе - 0,40 лв.";
            button5.Text = "Вода - 0,70 лв.";
            button6.Text = "Бира - 1,15 лв.";
            button7.Text = "Фъстъци - 1,50 лв.";
            button8.Text = "Бонбони - 1,30 лв.";
            grad = "P";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //za kafe
            label2.Visible = false;
            label3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label5.Visible =true;
            textBox1.Visible =true;
            button10.Visible = true;
            produkt = "k";
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //za voda
            label2.Visible = false;
            label3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label5.Visible = true;
            textBox1.Visible = true;
            button10.Visible = true;
            produkt = "v";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //za bira
            label2.Visible = false;
            label3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label5.Visible = true;
            textBox1.Visible = true;
            button10.Visible = true;
            produkt = "bira";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //za fustuci
            label2.Visible = false;
            label3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label5.Visible = true;
            textBox1.Visible = true;
            button10.Visible = true;
            produkt = "f";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //za bonboni
            label2.Visible = false;
            label3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label5.Visible = true;
            textBox1.Visible = true;
            button10.Visible = true;
            produkt = "b";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label6.Visible =true;
            int kol = int.Parse(textBox1.Text);
                  if (kol%2!=0)
                  {
                       textBox1.Text = "Не продаваме продуктите си на части!";
                  }
            double sum;
            if (grad=="P")
            {
                if (produkt=="k")
                {
                    sum = kol * kafePL;
                    label6.Text ="Крайната цена е " + sum + "0 лв.";
                }
                if (produkt == "v")
                {
                    sum = kol * vodaPL;
                    label6.Text = "Крайната цена е " + sum + "0 лв.";
                }
                if (produkt == "bira")
                {
                    sum = kol * biraPL;
                    label6.Text = "Крайната цена е " + sum + "0 лв.";
                }
                if (produkt == "f")
                {
                    sum = kol * fustukPL;
                    label6.Text = "Крайната цена е " + sum + "0 лв.";
                }
                if (produkt == "b")
                {
                    sum = kol * bonbonPL;
                    label6.Text = "Крайната цена е " + sum + "0 лв.";
                }

            }
            
            if (grad == "S")
            {
                if (produkt == "k")
                {
                    sum = kol * kafeSF;
                    label6.Text = "Крайната цена е " + sum + "0 лв.";
                }
                if (produkt == "v")
                {
                    sum = kol * vodaSF;
                    label6.Text = "Крайната цена е " + sum + "0 лв.";
                }
                if (produkt == "bira")
                {
                    sum = kol * biraSF;
                    label6.Text = "Крайната цена е " + sum + "0 лв.";
                }
                if (produkt == "f")
                {
                    sum = kol * fustukSF;
                    label6.Text = "Крайната цена е " + sum + "0 лв.";
                }
                if (produkt == "b")
                {
                    sum = kol * bonbonSF;
                    label6.Text = "Крайната цена е " + sum + "0 лв.";
                }
            }
            if (grad == "V")
            {
                if (produkt == "k")
                {
                    sum = kol * kafeVR;
                    label6.Text = "Крайната цена е " + sum + "0 лв.";
                }
                if (produkt == "v")
                {
                    sum = kol * vodaVR;
                    label6.Text = "Крайната цена е " + sum + "0 лв.";
                }
                if (produkt == "bira")
                {
                    sum = kol * biraVR;
                    label6.Text = "Крайната цена е " + sum + "0 лв.";
                }
                if (produkt == "f")
                {
                    sum = kol * fustukVR;
                    label6.Text = "Крайната цена е " + sum + "0 лв.";
                }
                if (produkt == "b")
                {
                    sum = kol * bonbonVR;
                    label6.Text = "Крайната цена е " + sum + "0 лв.";
                }
            }

        }
    }
}
