using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablica_dvoiki_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nomer na redove");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Nomer na koloni");
            int k = int.Parse(Console.ReadLine());
            for (int i = 1; i <= r; i++)
            {
                Console.Write("Red: {0}", +i);
                for (int j = 1; j <= k; j++)
                {
                    Console.Write("{0},{1}", i, j);
                }
                Console.WriteLine();
            }
        }
    }
}
