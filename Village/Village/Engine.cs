using System;

namespace Village
{
   class Engine
    {
        public void Run()
        {
            Controller controller = new Controller();
            const string endCommand = "End";
            string[] input = Console.ReadLine().Split(" ");
            while (input[0] != endCommand)
            {
                switch (input[0])
                {
                    case "Village":
                        Console.WriteLine(controller.ProcessVillageCommand(input[1], input[2]));
                        break;
                    case "Settle":
                        Console.WriteLine(controller.ProcessSettleCommand(input[1], int.Parse(input[2]), int.Parse(input[3]), input[4]));
                        break;
                    case "Rebel":
                        Console.WriteLine(controller.ProcessRebelCommand(input[1], int.Parse(input[2]), int.Parse(input[3])));
                        break;
                    case "Day":
                        Console.WriteLine(controller.ProcessDayCommand(input[1]));
                        break;
                    case "Attack":
                        Console.WriteLine(controller.ProcessAttackCommand(int.Parse(input[1]), input[2]));
                        break;
                    case "Info":
                        Console.WriteLine(controller.ProcessInfoCommand(input[1]));
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine().Split(" ");
            }
            Console.WriteLine(controller.ProcessEndCommand());
            Environment.Exit(0);
        }
    } 
}