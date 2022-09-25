using System;
using System.Collections.Generic;
using System.Text;

namespace BrokerCompanySystem
{
    internal class Engine
    {
        public void Run()
        {
            ControllerClass controllerClass = new ControllerClass();
            Console.WriteLine("Commands:\nCreateCompany*<name>\nRegisterBuilding*<type, name, city, stars, rentAmount, companyName>\nRegisterBroker*<name, age, city, companyName>\nRentBuilding*<companyName, buildingName, brokerName>\nCompanyInfo*<name>\nShutdown<>\n");
            string[] input = Console.ReadLine().Split('*');
            while (input[0] != "Shutdown")
            {
                switch (input[0])
                {
                    case "CreateCompany":
                        Console.WriteLine(controllerClass.CreateCompany(input[1]));
                        break;
                    case "RegisterBuilding":
                        Console.WriteLine(controllerClass.RegisterBuilding(input[1], input[2], input[3], int.Parse(input[4]), double.Parse(input[5]), input[6]));
                        break;
                    case "RegisterBroker":
                        Console.WriteLine(controllerClass.RegisterBroker(input[1], int.Parse(input[2]), input[3], input[4]));
                        break;
                    case "RentBuilding":
                        Console.WriteLine(controllerClass.RentBuilding(input[1], input[2], input[3]));
                        break;
                    case "CompanyInfo":
                        Console.WriteLine(controllerClass.CompanyInfo(input[1]));
                        break;
                    default:
                        Console.WriteLine("fuckin dumbahh cant write no command right bruh (ToT)");
                        break;
                }
                input = Console.ReadLine().Split('*');
            }
            Console.WriteLine(controllerClass.Shutdown());
        }
    }
}
