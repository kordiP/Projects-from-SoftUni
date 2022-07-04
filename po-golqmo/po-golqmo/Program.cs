using System;

namespace po_golqmo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x > y) { Console.WriteLine(x); }
            else { Console.WriteLine(y); }
        }
    }
}
