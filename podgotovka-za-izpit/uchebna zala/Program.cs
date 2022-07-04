using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uchebna_zala
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            if (h >= 3 && w >= h && w<=100)
            {
                h = h * 100;
                double h1 = h - 100;
                double h2 = h1 % 70;
                double h3 = h1 - h2;
                double broi_biura_h=h3/70;
                w = w * 100;
                double w1 = w % 120;
                double w2 = w - w1;
                double broi_biura_w = w2 / 120;
                double biura = (broi_biura_h * broi_biura_w) - 3;
                Console.WriteLine(biura);
            }
            else 
            {
                Console.WriteLine("Ne moje da ima takiva razmeri!!!");
            }
        }
    }
}
