using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachka_ot_dok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete b1:");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete b2:");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete h:");
            double h = double.Parse(Console.ReadLine());
            double area = (b1 + b2) * h / 2;
            Console.WriteLine("Liceto na trapeca e: {0} kv.cm", area);
        }
    }
}
