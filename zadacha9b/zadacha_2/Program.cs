using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи страна на квадрата:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Кой символ да се отпечати?");
            char m = char.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(m);
                }
                Console.WriteLine();
            }
        }
    }
}
