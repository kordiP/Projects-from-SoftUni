using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace judge_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n >= 2 && n <= 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write("*");
                    for (int h = 0; h < n-2; h++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Ne e v dadeniq radius chisla");
            }
        }
    }
}
