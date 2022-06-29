using System;

namespace EasterEgg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int red = 0, orange = 0, blue = 0, green = 0, maxCount = 0;
            string[] eggColors = { "red", "orange", "blue", "green" };
            int[] eggCounts = new int[4];
            string maxColor = " ";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red": eggCounts[0]++;break;
                    case "orange": eggCounts[1]++;break;
                    case "blue": eggCounts[2]++;break;
                    case "green": eggCounts[3]++;break;
                }
            }
            Console.WriteLine($"Red eggs: {eggCounts[0]}");
            Console.WriteLine($"Orange eggs: {eggCounts[1]}");
            Console.WriteLine($"Blue eggs: {eggCounts[2]}");
            Console.WriteLine($"Green eggs: {eggCounts[3]}");
            for (int i = 0; i < eggCounts.Length; i++)
            {
                if (eggCounts[i] > maxCount)
                {
                    maxCount = eggCounts[i];
                    maxColor = eggColors[i];
                }
            }
            Console.WriteLine($"Max eggs: {maxColor} -> {maxCount}");
        }
    }
}
