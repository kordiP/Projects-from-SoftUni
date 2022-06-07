using System;

namespace NOD_i_NOK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int d = 2;
            int nod = 1;
            int nok = 1;

            while (a > 1 || b > 1)
            {
                while (a % d == 0 || b % d == 0)
                {
                    if (a % d == 0 && b % d == 0)
                    {
                        nod *= d;
                        a /= d;
                        b /= d;
                    }
                    else if (a % d == 0)
                        a /= d;
                    else
                        b /= d;
                    nok *= d;
                }
                d++;
            }
            Console.WriteLine(nod);
            Console.WriteLine(nok);
        }
    }
}
