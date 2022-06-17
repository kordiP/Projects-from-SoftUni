using System;

namespace NOD_s_cherta
{
    internal class Program
    {
        static void Main()
        {
            int NOD = 1;
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int d = 2;
            int nc1 = n1;
            int nc2 = n2;
            Console.WriteLine(); Console.WriteLine($"Start na namirane na NOD na chislata {n1} i {n2}!"); Console.WriteLine();
            while (nc1 > 1)
            {
                if (nc1 % d == 0 && nc2 % d == 0)
                {
                    nc1 /= d;
                    nc2 /= d;
                    NOD *= d;
                }
                else if (nc1 % d == 0)
                    nc1 /= d;
                else if (nc2 % d == 0)
                    nc2 /= d;
                else
                {
                    d++;
                    continue;
                }
                Console.WriteLine($"{nc1}, {nc2}  |  {d}");
            }
            Console.WriteLine();
            if (NOD != 1) Console.WriteLine("NOD-a e: " + NOD + ".");
            else Console.WriteLine($"Chislata {n1} i {n2} sa vzaimno prosti.");
        }
    }
}
