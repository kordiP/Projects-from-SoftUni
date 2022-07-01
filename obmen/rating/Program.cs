using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broi_uchastnici = int.Parse(Console.ReadLine());
            int d = 0; double d1 = 0;
            int i = 0; double i1 = 0;
            int n = 0; double n1 = 0;
            int e = 0; double e1 = 0;
            double d2=0; double i2=0; double n2=02; double e2=0;
            double broi_doge; double broi_iota; double broi_neo; double broi_estd;
            for (int j = 1; j <= broi_uchastnici; j++)
            {
                string valuta = Console.ReadLine();
                if (valuta == "DOGE")
                {
                    d++;
                    broi_doge = double.Parse(Console.ReadLine());
                    d1 = broi_doge * 0.07 + d1;
                }
                else if (valuta == "IOTA")
                {
                    i++;
                    broi_iota = double.Parse(Console.ReadLine());
                    i1 = broi_iota * 1.44 +i1;
                }
                else if (valuta == "NEO")
                {
                    n++;
                    broi_neo = double.Parse(Console.ReadLine());
                    n1 = broi_neo * 28.5 +n1;
                }
                else if (valuta == "ESTD")
                {
                    e++;
                    broi_estd = double.Parse(Console.ReadLine());
                    e1 = broi_estd * 25 + e1;
                }
            }
            double eur = d1 + i1 + n1 + e1;
            d2 = d1 / eur * 100; i2 = i1 / eur * 100; n2 = n1 / eur * 100; e2 = e1 / eur * 100;
            Console.WriteLine($"Total votes = {broi_uchastnici}, Money in market = {eur:0.00} EUR");
            Console.WriteLine($"DOGE's contribution: {d2:0.00}%; People who use DOGE: {d}");
            Console.WriteLine($"IOTA's contribution: {i2:0.00}%; People who use IOTA: {i}");
            Console.WriteLine($"NEO's contribution: {n2:0.00}%; People who use NEO: {n}");
            Console.WriteLine($"ESTD's contribution: {e2:0.00}%; People who use ESTD: {e}");
        }
    }
}
