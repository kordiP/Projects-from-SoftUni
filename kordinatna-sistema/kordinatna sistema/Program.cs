using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordinatna_sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x1, x2, y1, y2;
            Console.WriteLine("Vuvedete stoinostite na a, x1, x2, b, y1, y2");
            a = double.Parse(Console.ReadLine());
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            if (a==x1 || a==x2 || b==y1 || b==y2)
            {
                Console.WriteLine("Leji na strana");
            }
            else
            {
                Console.WriteLine("Ne leji na strana"); 
            }
        }
    }
}
