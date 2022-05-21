using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi cifra:");
            Console.WriteLine("1 - lice na kvadrat");
            Console.WriteLine("2 - lice na pravougulnik");
            Console.WriteLine("3 - lice na trapec");
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            if (x==1)
            {
               Console.Write("strana na kvadrat a=");
                double a = double.Parse(Console.ReadLine());
                if (a > 0)
                {
                    double s1 = a * a;
                    Console.WriteLine("Liceto S={0}",s1);
                }
                else Console.WriteLine("ne sashtestvuva takuv kvadrat!");
            }
            else if (x==2)
            {
                Console.Write("strana na pravougulnik a=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("strana na pravougulnik b=");
                double q = double.Parse(Console.ReadLine());
                if (b <= 0 || q <= 0) { Console.WriteLine("ne sashtestvuva takuv pravougulnik!"); }
                else
                {
                    double s2 = b * q;
                    Console.WriteLine("Liceto S={0}", s2);
                }
            }
            else if (x==3)
            {
                Console.Write("strana na trapec a=");
                double c = double.Parse(Console.ReadLine());
                Console.Write("strana na trapec b=");
                double d = double.Parse(Console.ReadLine());
                Console.Write("visochina na trapec h=");
                double h = double.Parse(Console.ReadLine());
                if (c <= 0 || d <= 0 || h <= 0)
                { Console.WriteLine("ne sashtestvuva takuv trapec!"); }
                else
                {
                    double s3 = (c + d) * h / 2;
                    Console.WriteLine("LIceto na trapeca S={0}",s3);
                }
            }
            else Console.WriteLine("Greshni vhodni danni!!!");
        }
    }
}
