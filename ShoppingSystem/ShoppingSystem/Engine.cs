using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSystem
{
    internal class Engine
    {
        public void Run()
        {
            Controller control = new Controller();
            const string endCommand = "End";
            List<string> input = Console.ReadLine().Split(" ").ToList();
            while (input[0] != endCommand)
            {
                switch (input[0])
                {
                    case "Product":
                        Console.WriteLine(control.ProcessProductCommand(input));
                        break;
                    case "Service":
                        Console.WriteLine(control.ProcessServiceCommand(input));
                        break;
                    case "Checkout":
                        Console.WriteLine(control.ProcessCheckoutCommand(input));
                        break;
                    case "Info":
                        Console.WriteLine(control.ProcessInfoCommand(input));
                        break;
                }
                input = Console.ReadLine().Split(" ").ToList();
            }
            Console.WriteLine(control.ProcessEndCommand());
        }
    }
}