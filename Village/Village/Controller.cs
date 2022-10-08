using System;
using System.Collections.Generic;
using System.Linq;
namespace Village
{
    class Controller
    {
        private Dictionary<string, Village> villages = new Dictionary<string, Village>();
        private Dictionary<string, Rebel> rebels = new Dictionary<string, Rebel>();
        public int attackCount = 0;
        public string ProcessVillageCommand(string name, string location)
        {
            Village village = new Village(name, location);
            villages.Add(name, village);
            return $"Created Village {name}!";
        }

        public string ProcessSettleCommand(string name, int age, int productivity, string villageName)
        {
            Peasant peasant = new Peasant(name, age, productivity);
            villages[villageName].AddPeasant(peasant);
            return $"Settled Peasant {name} in Village {villageName}!";
        }

        public string ProcessRebelCommand(string name, int age, int harm)
        {
            Rebel rebel = new Rebel(name, age, harm);
            rebels.Add(name, rebel);
            return $"Rebel {name} joined the gang!";
        }

        public string ProcessDayCommand(string villageName)
        {
            int resBefore = villages[villageName].Resource;
            villages[villageName].PassDay();
            int resAfter = villages[villageName].Resource;
            return $"Village {villageName} resource increased with {resAfter - resBefore}!";
        }

        public string ProcessAttackCommand(int rebelCount, string villageName)
        {
            if (rebels.Count == 0) return $"No rebels to perform raid...";
            int totalHarm = 0;
            for (int i = 0; i < rebelCount; i++)
                totalHarm += rebels.ElementAt(i).Value.Harm;
            villages[villageName].Resource -= totalHarm;
            villages[villageName].KillPeasants(rebelCount / 2);
            attackCount++;
            return $"Village {villageName} lost {totalHarm} resources and {rebelCount / 2} peasants!";
        }
        public string ProcessInfoCommand(string side)
        {
            string toReturn = "";
            if (side == "Rebel")
            {
                if (rebels.Count == 0)
                    toReturn = "No rebels";
                else
                    toReturn += "Rebels:\n";
                    for (int i = 0; i < rebels.Count; i++)
                        toReturn += rebels.ElementAt(i).Value.ToString();
            }
            else
            {
                if (villages.Count == 0)
                    toReturn = "No villages";
                else
                    toReturn += "Villages:\n";
                    for (int i = 0; i < villages.Count; i++)
                        toReturn += villages.ElementAt(i).Value.ToString();
            }
            toReturn = toReturn.Trim();
            return toReturn;
        }

        public string ProcessEndCommand()
        {
            return $"Villages: {villages.Count}\nRebels: {rebels.Count}\nAttacks on Villages: {attackCount}";
        }
    }
}
