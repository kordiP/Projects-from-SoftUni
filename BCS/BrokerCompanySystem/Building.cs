using System;
using System.Collections.Generic;
using System.Text;

namespace BrokerCompanySystem
{
    abstract class Building 
    {
        private string name;
        private string city;
        private int stars;
        private double rentAmmount;
        private bool isAvailable;
        public string Name 
        { 
            get 
            {
               return name;
            }
            set
            {
                if (value.Length != 0 && value != null) name = value;
                else throw new ArgumentException("Building name must not be null or empty!");
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if (value.Length != 0 && value != null) city = value;
                else throw new ArgumentException("City must not be null or empty!");
            }
        }
        public int Stars
        {
            get
            {
                return stars;
            }
            set
            {
                if (stars >= 0 && stars <= 6) stars = value;
                else throw new ArgumentException("Stars cannot be less than 0 or above 5!");
            }
        }
        public double RentAmmount
        {
            get { return rentAmmount; }
            set
            {
                if (value > 0) rentAmmount = value;
                else throw new ArgumentException("Rent amount cannot be less or equal to 0!");
            }
        }
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }
        public Building(string name, string city, int stars, double rentAmmount)
        {
            Name = name;
            City = city;
            Stars = stars;
            RentAmmount = rentAmmount;
            isAvailable = true;
        }
        public override string ToString()
        {
            return $"****Building: {Name} <{Stars}>\n****Location: {City}\n****RentAmount: {RentAmmount}\n****Is Available: {IsAvailable}";
        }
    }
}
