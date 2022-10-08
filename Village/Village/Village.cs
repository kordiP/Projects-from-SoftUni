using System;
using System.Collections.Generic;
namespace Village
{
    class Village
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length >= 2 && value.Length <= 40) name = value;
                else throw new ArgumentException("Name should be between 2 and 40 characters!");
            }
        }
        private string location;

        public string Location
        {
            get { return location; }
            set
            {
                if (value.Length >= 3 && value.Length <= 45) location = value;
                else throw new ArgumentException("Location should be between 3 and 45 characters!");
            }
        }
        private int resource;

        public int Resource
        {
            get { return resource; }
            set { resource = value; }
        }

        private List<Peasant> peasants;
        public Village(string name, string location)
        {
            Name = name;
            Location = location;
            peasants = new List<Peasant>();
        }
        public void AddPeasant(Peasant peasant)
        {
            peasants.Add(peasant);
        }
        public int PassDay()
        {
            foreach (var item in peasants)
                Resource += item.Productivity;
            return Resource;
        }
        public List<Peasant> KillPeasants(int count)
        {
            if (count > peasants.Count)
            {
                peasants.RemoveRange(0, peasants.Count);
                return peasants;
            }
            else
            {
                List<Peasant> removed = new List<Peasant>();
                for (int i = 0; i < count; i++)
                {
                    removed.Add(peasants[i]);
                    peasants.Remove(peasants[i]);
                }
                return removed;
            }
        }
        public override string ToString()
        {
            string returnThat = $"Village - {Name} ({Location})\nResources - {Resource}\nPeasants – ({peasants.Count})\n";
            for (int i = 0; i < peasants.Count; i++)
                returnThat += peasants[i].ToString();
            return returnThat;
        }
    }
}