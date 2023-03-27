using BrokerCompanySystem;
using System;

namespace BrokerCompanySystem
{
    internal class EngineV1
    {
        public void Run()
        {
            ControllerClass controllerClass = new ControllerClass();
            MainMenu();
            ConsoleKey input = Console.ReadKey().Key;
            Console.Clear();
            if (input == ConsoleKey.D1)
            {
                Console.WriteLine(controllerClass.CreateCompany(ClearAndSaveStrings("You chose to create a company. What name would you like to give to it?\n")));
                input = Console.ReadKey().Key;
                if (input == ConsoleKey.Escape) MainMenu();
            }
        }
        private void MainMenu()
        {
            Console.WriteLine("\n                   Broker Company System Menu.\n\n\n\n1. Create Company\n\n2. Register Building\n\n3. Register Broker\n\n4. Rent Building\n\n5. Company Info\n\n6. Shutdown\n\n");

        }
        private string ClearAndSaveStrings(string outputForWriting)
        {
            Console.WriteLine(outputForWriting);
            string returnThat = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Press ESC to go back.");
            return returnThat;
        }
        private int ClearAndSaveInts(int returnThat, string outputForWriting)
        {
            Console.WriteLine(outputForWriting);
            returnThat = int.Parse(Console.ReadLine());
            Console.Clear();
            return returnThat;
        }
        private double ClearAndSaveDoubles(double returnThat, string outputForWriting)
        {
            Console.WriteLine(outputForWriting);
            returnThat = double.Parse(Console.ReadLine());
            Console.Clear();
            return returnThat;
        }
    }
}
