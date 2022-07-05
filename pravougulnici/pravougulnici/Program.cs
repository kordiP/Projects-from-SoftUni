using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravougulnici
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                int b = int.Parse(Console.ReadLine());
                if (b > 0) { int P = a + b + a + b; Console.WriteLine("P={0}",P); }
                else                 
                    Console.WriteLine("b...?");
                }
            else Console.WriteLine("a...?"); }
            }
        }
    


