
using System;

namespace prime_divisors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = n;
            int d = 2;
            while (n > 1)
            {
                if (n % d == 0)
                {
                    n /= d;
                    Console.Write(d + " ");
                }
                else
                    d++;
            }
            if (m == d)
                Console.Write("е просто.");
        }
    }
}
