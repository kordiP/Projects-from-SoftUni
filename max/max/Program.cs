using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Брой числа?");
            int numba = int.Parse(Console.ReadLine());
            Console.WriteLine("Напиши числата едно по едно:");
            int min = int.MaxValue;
            for (int i = 0; i < numba; i++)
            {
                int c = int.Parse(Console.ReadLine());
                if (min>c)
                {
                    min=c;
                }
            }
            Console.WriteLine(min);
        }
    }
}
