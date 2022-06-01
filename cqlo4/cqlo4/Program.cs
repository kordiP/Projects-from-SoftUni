using System;

namespace cqlo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x > 0) { Console.WriteLine("polojitelno"); }
            else
            {
                if (x == 0) { Console.WriteLine("nula"); }
                else { Console.WriteLine("otricatelno"); }

            }
        }
    }
}
