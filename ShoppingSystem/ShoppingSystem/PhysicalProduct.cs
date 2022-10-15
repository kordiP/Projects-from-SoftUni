using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSystem
{
    internal class PhysicalProduct : Product
    {
        private double weight;
        public double Weight
        {
            get => this.weight;
            set
            {
                if (value >= 0) this.weight = value;
                else throw new ArgumentException("Weight cannot be less or equal to 0!");
            }
        }
        public PhysicalProduct(string name, double price, double weight) : base(name, price)
        {
            this.Weight = weight;
        }
        public override string ToString()
        {
            return $"Name: {base.Name}\nPrice: {base.Price}\nWeight: {this.Weight}\n"; 
        }
    }
}
