using System;
using System.Collections.Generic;
using System.Text;

namespace BrokerCompanySystem
{
    internal class Residence : Building
    {
        private string residenceName;

        public string ResidenceName
        {
            get { return residenceName; }
            set
            {
                if (value.EndsWith(" Residence")) residenceName = value;
                else throw new ArgumentException("Name of residence buildings should end on Residence!");
            }
        }

        public Residence(string name, string city, int stars, double rentAmmount) : base(name, city, stars, rentAmmount)
        {
            Name = name;
            City = city;
            Stars = stars;
            RentAmmount = rentAmmount;
            ResidenceName = Name;
        }
    }
}
