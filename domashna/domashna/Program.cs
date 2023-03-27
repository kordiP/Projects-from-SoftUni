using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Колко числа искаш да въведеш?");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Въведи числата тук:");
            int umn = 1;
            double srednoAR = 1;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int p = int.Parse(Console.ReadLine());
                sum = sum + p;
                umn = umn*p;
                srednoAR = sum / n;
            }
            Console.WriteLine(umn);
            Console.WriteLine(srednoAR);
        }
    }
}
