using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int i, j, k;
            for (i = 1; i <= v; i++)
            {
                for (j = 1; j <= v - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i*2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                }
            }
        }
    }

