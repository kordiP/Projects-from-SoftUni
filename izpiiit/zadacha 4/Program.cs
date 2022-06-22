using System;
using System.Collections.Generic;
namespace zadacha_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string end = "End of match";
            SortedDictionary<string, int> players = new SortedDictionary<string, int>();
            string input = Console.ReadLine();
            while (input != end)
            {
                string[] data = input.Split(" - ");
                if (!players.ContainsKey(data[0]))
                    players.Add(data[0], int.Parse(data[1]));
                else
                    players[data[0]] += int.Parse(data[1]);
                input = Console.ReadLine();
            }
            foreach (var player in players)
            {
                Console.WriteLine($"{player.Key} has passed {player.Value} passes.");
            }
        }
    }
}
