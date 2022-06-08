using System;

namespace nod_na_evklid
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int originalNumber = n;
            int p = 2;
            while (n > 1)
            {
                while (n % p == 0)
                {
                    Console.Write(p);
                    if (n == p && n == originalNumber)
                        Console.Write(" е просто число.");
                    Console.WriteLine();
                    n /= p;
                }
                p++;
            }
        }
    }
}
