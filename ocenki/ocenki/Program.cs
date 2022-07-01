using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocenki
{
    class Program
    {
        static void Main(string[] args)
        {
            double ocenka = double.Parse(Console.ReadLine());
            if (ocenka >= 5.50) { Console.WriteLine("Excellent!"); }
            else
            {
                if (ocenka <= 5.49 && ocenka >= 4.50) { Console.WriteLine("Very good!"); }
                else
                {
                    if (ocenka >= 3.50) { Console.WriteLine("Good"); }

                    else
                    { { if (ocenka >= 2.50) { Console.WriteLine("Fair"); } }

                    else 
{ if (ocenka >= 2.50) { Console.WriteLine("Fair"); } }
                    }
                }
            }
        }
    }
}


