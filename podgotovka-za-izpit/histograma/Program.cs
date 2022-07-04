using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("broi chisla");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int chislo;
            double p1;
            double p2;
            double p3;
            double p4;
            double p5;
            double b1 = 0;
            double b2 = 0;
            double b3 = 0;
            double b4 = 0;
            double b5 = 0;
            if (n >= 1 && n <= 1000)
            {
                for (int i = 1; i <= n; i++)
                {
                    chislo = int.Parse(Console.ReadLine());
                    if (chislo >= 1 && chislo <= 199)
                        b1++;
                    else if (chislo >= 200 && chislo <= 399)
                        b2++;
                    else if (chislo >= 400 && chislo <= 599)
                        b3++;
                    else if (chislo >= 600 && chislo <= 799)
                        b4++;
                    else if (chislo >= 800 && chislo <= 1000)
                        b5++;
                    else
                        Console.WriteLine("Ne e v intervala ot dopustimi stoinosti.");
                }
            }
            Console.WriteLine();
            p1 = b1 / n * 100; Console.WriteLine("p1="+ p1 + "%");
            p2 = b2 / n * 100; Console.WriteLine("p2="+ p2 + "%"); 
            p3 = b3 / n * 100; Console.WriteLine("p3="+ p3 + "%");
            p4 = b4 / n * 100; Console.WriteLine("p4="+ p4 + "%");
            p5 = b5 / n * 100; Console.WriteLine("p5="+ p5 + "%");

        }
    }
}
