using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи край на редицата числа:");
            int num = int.Parse(Console.ReadLine());
            int n = 1;
            do
            {
                Console.Write(n + " ");
                n = 2 * n + 1;
            } while (n<=num );
            Console.WriteLine();

        }
    }
}
