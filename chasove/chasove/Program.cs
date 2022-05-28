using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chasove
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            if (h <= 10) { Console.WriteLine("Good Morning!"); }
            else
            {
                if (h >= 11 && h <= 17) { Console.WriteLine("Good .. day?"); }
                else
                {
                    if (h >= 18 && h <= 23) { Console.WriteLine("Good evening"); }
                    else
                    {
                        if (h >= 23 && h < 24) { Console.WriteLine("Good night"); }
                        else { Console.WriteLine("Not a valid time"); }


                    }
                }
            }
        }
    }
}
