using System;
namespace zad
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int current = int.Parse(input);
            int currentCount = 1;
            int longestCount = 0;
            int longestNumber = default;
            int cycleCount = 0;
            while (input != "end")
            {
                cycleCount++;
                if (current == int.Parse(input) && cycleCount != 1)
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > longestCount)
                    {
                        longestNumber = current;
                        longestCount = currentCount;
                    }
                    current = int.Parse(input);
                    currentCount = 0;
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i <= longestCount; i++)
            {
                Console.WriteLine(longestNumber);
            }
        }
    }
}