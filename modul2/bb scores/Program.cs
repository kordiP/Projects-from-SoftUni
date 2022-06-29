using System;
using System.Linq;
using System.Collections.Generic;
namespace bb_scores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> players = new Dictionary<string, int>();
            const string EndCommand = "END";
            string[] input = Console.ReadLine().Split();
            while (input[0] != EndCommand)
            {
                if (!players.ContainsKey(input[0]))  // '!' ne otpred --> sudurja
                {
                    //players.Add(input[0], int.Parse(input[2])); // input 2 shtot 0 e ime, a 1 e '-'
                    players[input[0]] = int.Parse(input[2]); 
                }
                else
                {
                    players[input[0]] += int.Parse(input[2]);
                }

                input = Console.ReadLine().Split();
            }
            foreach (string name in players.Keys.OrderBy(name => name))
            {
                Console.WriteLine(name + "->" + players[name]);
            }
        }
    }
}
