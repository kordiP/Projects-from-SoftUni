using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perimetur_i_lice_na_krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete r na kruga: ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("Liceto na kruga e {0}, a perimetura na kruga e {1}.", Math.Round(area, 2), Math.Round(perimeter, 2));

        }
    }
}
