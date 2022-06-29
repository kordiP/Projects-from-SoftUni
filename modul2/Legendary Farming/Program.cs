using System;
using System.Collections.Generic;
using System.Linq;
namespace Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> LegendaryItems = new Dictionary<string, string>();
            LegendaryItems["shards"] = "Shadowmourne";
            LegendaryItems["fragments"] = "Valanyr";
            LegendaryItems["motes"] = "Dragonwrath";
            Dictionary<string, int> KeyMaterials = new Dictionary<string, int>();
            KeyMaterials["shards"] = 0;
            KeyMaterials["fragments"] = 0;
            KeyMaterials["motes"] = 0;
            Dictionary<string, int> Junk = new Dictionary<string, int>();
            do
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();
                    if (KeyMaterials.ContainsKey(material))
                    {
                        KeyMaterials[material] += quantity;
                        if (KeyMaterials[material] >= 250)
                            break;
                    }
                    else if (Junk.ContainsKey(material))
                        Junk[material] += quantity;
                    else
                        Junk[material] = quantity;
                }
            } while (KeyMaterials["shards"] < 250 && KeyMaterials["fragments"] < 250 && KeyMaterials["motes"] < 250);
            string winMaterial = KeyMaterials.OrderByDescending(x => x.Value).First().Key;
            Console.WriteLine(LegendaryItems[winMaterial] + " obtained!");
            KeyMaterials[winMaterial] -= 250;
            for (int i = 0; i < KeyMaterials.Count; i++)
            {
                string currentMaterial = KeyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ElementAt(i).Key;
                Console.WriteLine(currentMaterial + ": " + KeyMaterials[currentMaterial]);
            }
            for (int i = 0; i < Junk.Count; i++)
            {
                string currentJunk = Junk.OrderBy(x => x.Key).ElementAt(i).Key;
                Console.WriteLine(currentJunk + ": " + Junk[currentJunk]);
            }
        }
    }
}
