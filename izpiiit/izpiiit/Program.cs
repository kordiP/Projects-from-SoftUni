using System;

namespace izpiiit
{
    internal class Program
    {
        static void Main()
        {
            int numberOfBuys = int.Parse(Console.ReadLine());
            int finalPrice = 0;
            for (int i = 0; i < numberOfBuys; i++)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "desk":
                        finalPrice += 1789;
                        break;
                    case "chair":
                        finalPrice += 1699;
                        break;
                    case "computer":
                        finalPrice += 5899;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}
