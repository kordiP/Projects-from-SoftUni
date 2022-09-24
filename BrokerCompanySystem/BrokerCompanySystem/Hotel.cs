using System;
using System.Collections.Generic;
using System.Text;

namespace BrokerCompanySystem
{
    internal class Hotel : Building
    {
        private string hotelName;
        public string HotelName
        {
            get { return hotelName; }
            set
            {
                if (value.EndsWith(" Hotel")) hotelName = value;
                else throw new ArgumentException("Name of hotel buildings should end on Hotel!");
            }
        }
        public Hotel(string name, string city, int stars, double rentAmmount) : base(name, city, stars, rentAmmount)
        {
            Name = name;
            City = city;
            Stars = stars;
            RentAmmount = rentAmmount;
            HotelName = Name;
        }
    }
}
