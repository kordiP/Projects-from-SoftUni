using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triagalniche
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duljiina na hipotenuza:");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("Duljina na visochina");
            int h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= v; i++)
            {
                for (i = 1; i <= h-i; i++)
                {
                    Console.Write("██");
                }
                for (int j = 0; j < h; j = j + 2)
                {
                    Console.Write("██");
                }
                Console.WriteLine();
                
            }
        }
    }
}
