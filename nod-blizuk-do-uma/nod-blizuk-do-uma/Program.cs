
using System;

namespace nod_blizuk_do_uma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = a > b ? a : b;   // Math.Max(a, b);
            for (; n % a != 0 || n % b != 0; n++) ;
            Console.WriteLine(n);
        }
    }
}
