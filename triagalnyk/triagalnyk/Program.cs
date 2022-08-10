using System;

namespace triagalnyk
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =int.Parse(Console.ReadLine());
            int b =int.Parse(Console.ReadLine());
            int c =int.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && a < c + b) { Console.WriteLine("ima"); }
            else { Console.WriteLine("nqma"); }
        }
    }
}
