
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи крайно число за редицата:");
            int i = int.Parse(Console.ReadLine());
            int p = 1;
            while (p<=i)
            {
                Console.Write(p+" ");
                p = 2 * p + 1;
            }
        }
    }
}
