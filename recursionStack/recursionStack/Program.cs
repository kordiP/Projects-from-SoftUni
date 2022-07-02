using System;

namespace recursionStack
{
    internal class Program
    {
        static int k;
        static void Main()
        {
            k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ElementN(n));
            Console.Beep(); // beep :>
        }
        public static int ElementN(int n)
        {
            Console.WriteLine("--> " + n);
            if (n == 1) return k;
            else if (n % 3 == 0)
            {
                return 2 * ElementN(n / 3) + 1;
            }
            else if ((n + 1) % 3 == 0)
            {
                return ElementN((n + 1) / 3) + 1;
            }
            else
            {
                return ElementN((n - 1) / 3) + 2;
            }
        }
    }
}
