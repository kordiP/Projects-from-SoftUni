using System;
using System.Collections.Generic;
using System.Text;

namespace BrokerCompanySystem
{
    internal class Broker
    { 
        // POLE SUS SGRADI +++
		private string name;

		public string Name
		{
			get { return name; }
			set 
			{ 
				if (value == null && value.Length == 0) throw new ArgumentException("Broker name must not be null or empty!");
				name = value;
			}
		}
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 70 || value <= 16) throw new ArgumentException("Broker's age cannot be less than 16 or above 70!");
                age = value;
            }
        }
        private string city;

        public string City
        {
            get { return city; }
            set
            {
                if (value == null && value.Length == 0) throw new ArgumentException("City must not be null or empty!");
                city = value;
            }
        }
        private double bonus;

        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public Broker(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
            Bonus = 0;
        }
    }
}
