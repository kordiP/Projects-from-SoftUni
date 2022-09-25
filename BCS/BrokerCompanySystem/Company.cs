using System;
using System.Collections.Generic;
using System.Text;

namespace BrokerCompanySystem
{
    internal class Company
    {
        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                if (value != null && value.Length != 0) name = value;
                else throw new ArgumentException("Company name must not be null or empty!");
            }
        }
        private Dictionary<string, Building> buildings;
        public Dictionary<string, Building> Buildings
        {
            get { return buildings; }
            set { buildings = value; }
        }
        private Dictionary<string, Broker> brokers;
        public Dictionary<string, Broker> Brokers
        {
            get { return brokers; }
            set { brokers = value; }
        }
        public Company(string name)
        {
            Name = name;
            Buildings = new Dictionary<string, Building>();
            Brokers = new Dictionary<string, Broker>();
        }
        public void AddBroker (Broker broker)
        {
            if (!Brokers.ContainsValue(broker)) Brokers.Add(broker.Name, broker);
        }
        public void AddBuilding(Building building)
        {
            if (!Buildings.ContainsValue(building)) Buildings.Add(building.Name, building);
        }
        public Broker GetBrokerByName(string name)
        {
            return Brokers[name]; 
        }
        public Building GetBuildingByName(string name)
        {
            return Buildings[name];
        }
        public override string ToString()
        {
            string returnThat = $"Company: {Name}\n##Brokers: {Brokers.Count}\n";
            foreach (var item in brokers)
                returnThat += $"{item.Value}\n";
            returnThat = returnThat + $"##Buildings:  {Buildings.Count}\n";
            foreach(var item in buildings)
                returnThat += $"{item.Value}\n";
            return returnThat;
        }
    }
}
