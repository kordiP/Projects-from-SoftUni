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
            double c, f;
            Console.WriteLine("C     F");
            for (c = 36.0; c < 38.0; c=c+0.1)
            {
                f = (9.0 / 5.0) * c + 32.0;
                Console.Write("{0,4}",c);
                Console.WriteLine("     {0}",f);
            }

        }
    }
}
