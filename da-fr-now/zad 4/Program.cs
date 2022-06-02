using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int broi_zem = int.Parse(Console.ReadLine());
            int light = 0;
            int moderate = 0;
            int strong = 0;
            int very_strong = 0;
            for (int i = 1; i <= broi_zem; i++)
            {
                double sila_zem = double.Parse(Console.ReadLine());
                if (sila_zem <= 4)
                {
                    light++;
                }
                else if (sila_zem > 4 && sila_zem <= 6)
                {
                    moderate++;
                }
                else if (sila_zem > 6 && sila_zem <= 7)
                {
                    strong++;
                }
                else if (sila_zem > 7)
                {
                    very_strong++;
                }
            }
            double l = (double)light / (double)broi_zem * 100;
            double m = (double)moderate / (double)broi_zem * 100;
            double s = (double)strong / (double)broi_zem * 100;
            double v = (double)very_strong / (double)broi_zem * 100;
            Console.WriteLine($"Light: {l:0.00}%");
            Console.WriteLine($"Moderate: {m:0.00}%");
            Console.WriteLine($"Strong: {s:0.00}%");
            Console.WriteLine($"Very Strong: {v:0.00}%");
        }
    }
}
