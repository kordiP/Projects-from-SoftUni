﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            double i = double.Parse(Console.ReadLine());
            double cm = i * 2.54;
            Console.WriteLine("centimeters = {0}", cm);
        }
    }
}
