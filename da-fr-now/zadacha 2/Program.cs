using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double podaruk = double.Parse(Console.ReadLine());
            double podaruk2 = 0.2 * (podaruk); //
            double podaruk3 = 0.7 * (podaruk2); //
            double podaruk4 = 0.5 * (podaruk2); // 
            double obshto_pod = podaruk + podaruk2 + podaruk3 + podaruk4;
            double razlika = budget - obshto_pod;
            Console.WriteLine(podaruk2);
            if (razlika >= 0) 
            {
                Console.WriteLine($"Yes! {razlika:0.00} leva left.");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(razlika):0.00} leva needed.");
            }
            
        }
    }
}
