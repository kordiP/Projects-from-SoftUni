using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete kolko kilometra iskate da putuvate: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("izberete den ili nosht: ");
            string den = Console.ReadLine();
            double obshto;
            if (n>=1 && n<=5000)
            {
                if (den == "day")
                {
                    if (n >= 100)
                    {
                        double vlak = 0.06;
                        obshto = n * vlak;
                        Console.WriteLine(obshto);
                    }
                    if (n >= 20 && n < 100)
                    {
                        double avtobus = 0.09;
                        obshto = n * avtobus;
                        Console.WriteLine(obshto);
                    }
                    if (n < 20)
                    {
                        double taksi_den = 0.79;
                        obshto = n * taksi_den + 0.7;
                        Console.WriteLine(obshto);
                    }

                }
                else if (den == "night")
                {
                    if (n >= 100)
                    {
                        double vlak = 0.06;
                        obshto = n * vlak;
                        Console.WriteLine(obshto);
                    }
                    if (n >= 20 && n < 100)
                    {
                        double avtobus = 0.09;
                        obshto = n * avtobus;
                        Console.WriteLine(obshto);
                    }
                    if (n < 20)
                    {
                        double taksi_nosht = 0.9;
                        obshto = n * taksi_nosht + 0.7;
                        Console.WriteLine(obshto);
                    }
                }
                else
                {
                    Console.WriteLine("Izberete den ili nosht, molq.");
                }
            }
            else
            {
                Console.WriteLine("Prekaleno mnogo/malko kilometri");
            }
            
        }
    }
}
