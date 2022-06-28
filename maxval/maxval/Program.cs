using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxval
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; int suma = 0;
            Console.WriteLine("Vavedi broi chisla");
            n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++)
            {
 int x = int.Parse(Console.ReadLine());
                suma = suma + x;
            }
            Console.WriteLine(suma);

        }
    }
}
