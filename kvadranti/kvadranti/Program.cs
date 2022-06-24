using System;

namespace kvadranti
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x >= 0 && y >= 0) { Console.WriteLine("kvadrant 1"); }
            if (x <= 0 && y >= 0) { Console.WriteLine("kvadrant 2"); }
            if (x <= 0 && y <= 0) { Console.WriteLine("kvadrant 3"); }
            if (x >= 0 && y <= 0) { Console.WriteLine("kvadrant 4"); }
            if (x == 0) { Console.WriteLine("ednata tochka leji na abscisata"); }
            if (y == 0) { Console.WriteLine("ednata tochka leji na ordinatata"); }
        }
    }
}
