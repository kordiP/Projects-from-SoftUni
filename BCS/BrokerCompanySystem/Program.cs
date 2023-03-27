using System;
using System.Collections.Generic;
using System.Linq;

namespace BrokerCompanySystem
{
    internal class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Press 1 for V1, 2 for V2.");
            ConsoleKey input = Console.ReadKey().Key;
            Console.Clear();
            if (input == ConsoleKey.D1)
            {
                EngineV1 enginev1 = new EngineV1();
                enginev1.Run();
            }
            else
            {
                //EngineV2 enginev2 = new EngineV2();
                //enginev2.Run();
            }
        }
    }
}
