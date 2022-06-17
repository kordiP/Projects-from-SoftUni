using System;

namespace every_way_to_100
{
    internal class Program
    {
        static void Main()
        {
            double targetPrice = double.Parse(Console.ReadLine());
            double[] allMoney = { 100.00, 50.00, 20.00, 10.00, 5.00, 2.00, 1.00, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 };
            double or = targetPrice;
            int waysCounter = 0, billCounter = 0;
            // for same numbers only
            for (int i = 0; i < allMoney.Length; i++)
            {
                if (targetPrice - allMoney[i] == 0)
                {
                    waysCounter++;
                    Console.WriteLine($"1 x {allMoney[i]}");
                }
                else if (targetPrice - allMoney[i] > 0)
                {
                    while (targetPrice > 0)
                    {
                        targetPrice = Math.Round(targetPrice - allMoney[i], 2); // Compiler has rounding errors, because it uses binary - can't represent 1/5 correctly, same as we can't 1/3!!!
                        billCounter++;
                    }
                    Console.WriteLine($"{billCounter} x {allMoney[i]}");
                    waysCounter++;
                }
                targetPrice = or;
                billCounter = 0;
            }
            // for different numbers
            for (int i = 0; i < allMoney.Length; i++)
            {

            }
        }        
    }
}
