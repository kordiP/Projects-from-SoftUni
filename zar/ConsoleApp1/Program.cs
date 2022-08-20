using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Natisni ENTER za da hvurlish zar!");
            Console.ReadLine();
            Random a = new Random();
            int zar = a.Next(1, 6);
            if (zar==1)
            {
                Console.WriteLine("*");
            }
            if (zar == 2)
            {
                Console.WriteLine("*");
                Console.WriteLine(" *");

            }
            if (zar == 3)
            {
                Console.WriteLine("*");
                Console.WriteLine(" *");
                Console.WriteLine("  *");
            }
            if (zar == 4)
            {
                Console.WriteLine("*  *");
                Console.WriteLine("*  *");
            }
            if (zar == 5)
            {
                Console.WriteLine("*  *");
                Console.WriteLine("  *  ");
                Console.WriteLine("*  *");
            }
            if (zar == 6)
            {
                Console.WriteLine("*  *");
                Console.WriteLine("*  *");
                Console.WriteLine("*  *");
            }
            Console.WriteLine("_");

        }
    }
}
