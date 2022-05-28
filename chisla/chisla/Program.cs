using System;

namespace chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int d = x / 10;
            int e = x % 10;
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
