using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meseci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedi nomer na mesec:");
            var m=int.Parse(Console.ReadLine());
            if (m==3||m==4||m==5)
            {
                Console.WriteLine("Prolet");
            }
            else if (m==6||m==7 || m ==8)
            {
                Console.WriteLine("Lqto");
            }
            else if (m==9 || m ==10 || m ==11)
            {
                Console.WriteLine("Esen");
            }
            else if (m==12 || m ==1 || m ==2) Console.WriteLine("Zima");
            else Console.WriteLine("Nepravilno vavedenii danni!");
        }
    }
}
