using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prodaljenia_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedi n:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("*");
                for (int j = 1; j < n-1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
        }
    }
}
