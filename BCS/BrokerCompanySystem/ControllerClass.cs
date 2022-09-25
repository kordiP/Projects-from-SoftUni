using System;
using System.Collections.Generic;
using System.Linq;

namespace BrokerCompanySystem
{
    internal class ControllerClass
    {
        private Dictionary<string, Company> companies = new Dictionary<string, Company>();
        public string CreateCompany(string name) //List<string> args *ako ne bachka      // done
        {
            if (companies.ContainsKey(name)) return $"Company {name} is already registered!";
            Company company = new Company(name);
            companies.Add(name, company);
            return $"Company {name} was successfully registered in the system!";
        } 

        public string RegisterBuilding(string type, string name, string city, int stars, double rentAmount, string companyName) //List<string> args
        {
            if (!companies.ContainsKey(companyName))
                return $"Invalid Company: {companyName}. Cannot find it in system!";
            if (companies[companyName].Buildings.ContainsKey(name)) return $"Building {name} is already registered in {companyName}!";
            Company com = companies[companyName];
            switch (type)
            {
                case "Hotel":
                    Hotel hotel = new Hotel(name, city, stars, rentAmount);
                    com.AddBuilding(hotel);
                    break;
                case "Business":
                    Business business = new Business(name, city, stars, rentAmount);
                    com.AddBuilding(business);
                    break;
                case "Residence":
                    Residence residence = new Residence(name, city, stars, rentAmount);
                    com.AddBuilding(residence);
                    break;
            }
            return $"Building {name} was successfully registered in {companyName} catalog!";
        }

        public string RegisterBroker(string name, int age, string city, string companyName) //List<string> args
        {
            Broker broker = new Broker(name, age, city);
            if (!companies.ContainsKey(companyName)) return $"Invalid Company: {companyName}. Cannot find it in system!";
            if (companies[companyName].Brokers.ContainsKey(name)) return $"Broker {name} is already part of {companyName}!";
            companies[companyName].AddBroker(broker);
            return $"Broker {name} was successfully hired in {companyName}!";
        }

        public string RentBuilding(string companyName, string buildingName, string brokerName) //List<string> args
        {
            Company com = companies[companyName];
            if (!companies.ContainsKey(companyName)) return $"Invalid Company: {companyName}. Cannot find it in system!";
            if (!com.Buildings.ContainsKey(buildingName)) return $"Invalid Building: {buildingName}. Cannot find it in {companyName} catalog!";
            if (!com.Brokers.ContainsKey(brokerName)) return $"Invalid Broker: {brokerName}. Cannot find employee in {companyName}!";
            if (com.Buildings[buildingName].IsAvailable == false) return $"Building: {buildingName} cannot be rented!";
            com.Buildings[buildingName].IsAvailable = false;
            com.Brokers[brokerName].ReceiveBonus(com.Buildings[buildingName]);
            return $"Successfully rented {buildingName}!\nBroker {brokerName} earned {companies[companyName].Brokers[brokerName].Bonus}!";
        }

        public string CompanyInfo(string companyName) //List<string> args
        {
            if (!companies.ContainsKey(companyName)) return $"Invalid Company: {companyName}. Cannot find it in system!";
            string returnThat = $"{companies[companyName]}";
            return returnThat;
        }

        public string Shutdown()
        {
            string returnThat = $"Companies: {companies.Count}\n";
            for (int i = 0; i < companies.Count; i++)
                returnThat += $"{companies.OrderBy(x => x.Value.Name).ElementAt(i).Value}\n";
            return returnThat;
        } 

    }
}
