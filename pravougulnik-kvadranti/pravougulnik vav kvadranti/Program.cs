﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravougulnik_vav_kvadranti
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            var x= double.Parse(Console.ReadLine());
            var y= double.Parse(Console.ReadLine());
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            if (x1<=x&&x<=x2&&y1<=y&&y<=y2)
            {
                Console.WriteLine("inside");
            }
            else Console.WriteLine("outside!");
        }
    }
}
