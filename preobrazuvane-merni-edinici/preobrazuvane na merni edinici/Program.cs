using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preobrazuvane_na_merni_edinici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete chisloto, koeto iskate da preobrazuvate: ");
            double size = double.Parse(Console.ReadLine());
            Console.WriteLine("Kakva e mernata edinica na vhodnoto chislo?(mm, cm, m, km, mi, in, ft, yd) : ");
            string vhod = Console.ReadLine().ToLower(); // merni edinici - mm cm km mili inches feet yard
            Console.WriteLine("Kakva e mernata edinica na izhodnoto chislo?(mm, cm, m, km, mi, in, ft, yd) : ");
            string izhod = Console.ReadLine().ToLower(); // merni edinici - mm cm km mili inches feet yard
            double result;
            if (vhod=="mm")
            {
                if (izhod=="cm")
                {
                    result = size / 10;
                    Console.WriteLine("Izhodnoto chislo e: "+result + izhod);
                }
                if (izhod == "km")
                {
                    result = size / 1000000;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod=="m")
                {
                    result = size / 1000;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "mi")
                {
                    result = size / 1609344;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "in")
                {
                    result = size * 0.03937;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "ft")
                {
                    result = size * 0.003281;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "yd")
                {
                    result = size * 0.001094;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
            }
            if (vhod == "cm")
            {
                if (izhod == "mm")
                {
                    result = size * 10;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "m")
                {
                    result = size / 100;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "km")
                {
                    result = size / 100000;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "mi")
                {
                    result = size / 160934.4;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "in")
                {
                    result = size * 0.3937;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "ft")
                {
                    result = size * 0.03281;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "yd")
                {
                    result = size * 0.01094;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
            }
            if (vhod == "m")
            {
                if (izhod == "mm")
                {
                    result = size * 1000;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "cm")
                {
                    result = size * 100;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "km")
                {
                    result = size / 1000;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "mi")
                {
                    result = size / 1609.344;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "in")
                {
                    result = size * 39.37;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "ft")
                {
                    result = size * 3.281;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "yd")
                {
                    result = size * 1.094;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
            }
            if (vhod == "km")
            {
                if (izhod == "mm")
                {
                    result = size * 1000000;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "cm")
                {
                    result = size * 100000;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "m")
                {
                    result = size * 1000;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "mi")
                {
                    result = size / 1.609344;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "in")
                {
                    result = size * 39370;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "ft")
                {
                    result = size * 3.281;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "yd")
                {
                    result = size * 1093.6;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
            }
            if (vhod == "km")
            {
                if (izhod == "mm")
                {
                    result = size * 1000000;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "cm")
                {
                    result = size * 100000;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "m")
                {
                    result = size * 1000;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "mi")
                {
                    result = size / 1.609344;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "in")
                {
                    result = size * 39370;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "ft")
                {
                    result = size * 3.281;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "yd")
                {
                    result = size * 1093.6;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
            }
            if (vhod == "mi")
            {
                if (izhod == "mm")
                {
                    result = size * 1609344;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "cm")
                {
                    result = size * 160934.4;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "m")
                {
                    result = size * 1609.344;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "km")
                {
                    result = size * 1.609344;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "in")
                {
                    result = size * 63360;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "ft")
                {
                    result = size * 5280;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "yd")
                {
                    result = size * 1760;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
            }
            if (vhod == "in")
            {
                if (izhod == "mm")
                {
                    result = size * 25.4;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "cm")
                {
                    result = size * 2.54;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "m")
                {
                    result = size * 0.0254;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "km")
                {
                    result = size * 0.0000254;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "mi")
                {
                    result = size / 63360;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "ft")
                {
                    result = size / 12;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "yd")
                {
                    result = size / 36;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
            }
            if (vhod == "ft")
            {
                if (izhod == "mm")
                {
                    result = size * 304.8;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "cm")
                {
                    result = size * 30.48;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "m")
                {
                    result = size * 0.3048;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "km")
                {
                    result = size * 0.0003048;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "mi")
                {
                    result = size / 5280;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "in")
                {
                    result = size * 12;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "yd")
                {
                    result = size / 3;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
            }
            if (vhod == "yd")
            {
                if (izhod == "mm")
                {
                    result = size * 914.4;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "cm")
                {
                    result = size * 91.44;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "m")
                {
                    result = size * 0.9144;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "km")
                {
                    result = size * 0.000914;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "mi")
                {
                    result = size / 1760;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "in")
                {
                    result = size * 36;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
                if (izhod == "ft")
                {
                    result = size * 3;
                    Console.WriteLine("Izhodnoto chislo e: " + result + izhod);
                }
            }
        }
    }
}
