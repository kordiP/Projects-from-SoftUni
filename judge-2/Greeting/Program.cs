﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var ime = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", ime);
        }
    }
}
