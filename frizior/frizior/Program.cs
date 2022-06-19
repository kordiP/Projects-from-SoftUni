using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frizior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napishete chislo, chrez koeto izbirate usluga:");
            Console.WriteLine("1-podstrigvane ");
            Console.WriteLine("2-boqdisvane ");
            Console.WriteLine("3-kudrene ");
            Console.WriteLine("Ako iskate nqkolko opcii ednovremenno, togava napishete cifrite edna do drugi");
            var x = int.Parse(Console.ReadLine());
            if (x==1)
            {
                Console.WriteLine("Vie izbrahte podstrigvane i tova struva 5 leva");
            }
           else if (x == 2)
            {
                Console.WriteLine("Vie izbrahte boqdisvane i tova struva 5 leva");
            }
            else if (x == 3)
            {
                Console.WriteLine("Vie izbrahte kudrene i tova struva 15 leva");
            }
            else if (x == 12 || x ==21)
            {
                Console.WriteLine("Vie izbrahte podstrigvane i boqdisvane i tova struva 10 leva");
            }
            else if (x==13 || x ==31)
            {
                Console.WriteLine("Vie izbrahte podstrigvane i boqdisvane i tova struva 20 leva");
            }
            else if (x == 23 || x ==32)
            {
                Console.WriteLine("Vie izbrahte boqdisvane i kudrene i tova struva 20 leva");
            }
            else if (x == 123||x==321 || x ==213 || x ==231 || x ==132 || x ==312)
            {
                Console.WriteLine("Vie izbrahte podstrigvane, boqdisvane i kudrene i tova struva 25 leva");
            }
            else Console.WriteLine("Nepravilno vavedeni danni");
        }
    }
}
