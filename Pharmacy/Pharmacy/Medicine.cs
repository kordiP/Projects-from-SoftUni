using System;

namespace Pharmacy
{
    internal class Medicine
    {
        private string name;
        private double price;
        public Medicine(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price");
                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            return $"Medicine: {this.name} with price {this.price}"; //String.Format("{0:0.00}", this.price)
        }
    }
}
