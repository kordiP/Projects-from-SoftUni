using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSystem
{
    internal class ServiceProduct : Product
    {
        private double time;

        public double Time
        {
            get => this.time; 
            set 
            {
                if (value > 0) time = value;
                else throw new ArgumentException("Time should be greater than 0!");
            }
        }
        public ServiceProduct(string name, double price, double time) : base (name, price)
        {
            this.Time = time;
        }
        public override string ToString()
        {
            return $"Name: {base.Name}\nPrice: {base.Price}\nTime: {this.Time}\n";
        }
    }
}
