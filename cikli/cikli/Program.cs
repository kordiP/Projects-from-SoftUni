using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cikli
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma=0;
            for (int i = 1; i <= 156; i++)
            {
                if (i%5==0)
                {
                    Console.WriteLine(i);
                }
                
                //suma=suma+i;       
            }
            //Console.WriteLine(suma);
        }
    }
}
