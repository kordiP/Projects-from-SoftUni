using System;
namespace stack
{
    internal class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            a[1] = k;
            for (int i = 2; i <= n; i++)
                if (i % 3 == 0) // e3
                    a[i] = 2 * a[i / 3] + 1;
                else if ((i + 1) % 3 == 0) // e2
                    a[i] = a[(i + 1) / 3] + 1;
                else // e4
                    a[i] = a[(i - 1) / 3] + 2;
            for (int i = 1; i < a.Length; i++)
                Console.Write($"{a[i]} ");
        }
    }
}
