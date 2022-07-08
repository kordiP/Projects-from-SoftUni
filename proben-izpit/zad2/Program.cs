using System;

namespace ots
{
    class Program
    {
        static void Main(string[] args)
        {
            string model = Console.ReadLine();
            int VIN = int.Parse(Console.ReadLine());
            string con = Console.ReadLine();
            double cena = double.Parse(Console.ReadLine());
            double profit = 15 * cena / 100;
            if (con == "good" && VIN <= 90000 && VIN % 2 == 0 && profit > 400)
            {
                Console.WriteLine($"yes - {model}");
                Console.WriteLine($"profit - {profit:0.00}");
            }
            else if (con == "bad" && VIN > 90000 && profit <= 400)
            {
                Console.WriteLine("no");
                Console.WriteLine("The car is in bad condition");
                Console.WriteLine($"VIN {VIN} is not valid");
                Console.WriteLine($"Cannot make discount, profit too low – {profit:0.00}");
            }
            else if (con == "bad" && VIN > 90000)
            {
                Console.WriteLine("no");
                Console.WriteLine("The car is in bad condition");
                Console.WriteLine($"VIN {VIN} is not valid");
            }
            else if (VIN > 90000 && profit <= 400)
            {
                Console.WriteLine("no");
                Console.WriteLine($"VIN {VIN} is not valid");
                Console.WriteLine($"Cannot make discount, profit too low – {profit:0.00}");
            }
            else if (con == "bad")
            {

                Console.WriteLine("no");
                Console.WriteLine("The car is in bad condition");
            }
            else if (VIN > 90000)
            {

                Console.WriteLine("no");
                Console.WriteLine($"VIN {VIN} is not valid");
            }
            else if (profit <= 400)
            {
                Console.WriteLine("no");
                Console.WriteLine($"Cannot make discount, profit too low – {profit:0.00}");
            }
        }
    }
}



