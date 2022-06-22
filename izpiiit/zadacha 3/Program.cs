using System;

namespace zadacha_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            const string end = "END OF GAME";
            int maxPoints = 0;
            string maxName = "";
            while (name != end)
            {
                int currentPoints = 0;
                if (name[name.Length - 1] == 'a') currentPoints += 10;
                if (name[name.Length - 1] == 'v') currentPoints += 13;
                if (name.Length >= 7) currentPoints += 33;
                if (name.Length < 7) currentPoints += 22;
                if (currentPoints > maxPoints)
                {
                    maxPoints = currentPoints;
                    maxName = name;
                }
                name = Console.ReadLine(); 
            }
            Console.WriteLine($"Winner is name: {maxName}");
            Console.WriteLine($"Points: {maxPoints}");
        }
    }
}
