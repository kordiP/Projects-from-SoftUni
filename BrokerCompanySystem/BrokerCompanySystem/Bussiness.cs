using System;
using System.Collections.Generic;
using System.Text;

namespace BrokerCompanySystem
{
    internal class Bussiness : Building
    {
        private string bussinessName;

        public string BussinessName
        {
            get { return bussinessName; }
            set
            {
                if (value.EndsWith(" Bussiness")) bussinessName = value;
                else throw new ArgumentException("Name of business buildings should end on Business!");
            }
        }

        public Bussiness(string name, string city, int stars, double rentAmmount) : base(name, city, stars, rentAmmount)
        {
            Name = name;
            City = city;
            Stars = stars;
            RentAmmount = rentAmmount;
            BussinessName = Name;
        }
    }
}
