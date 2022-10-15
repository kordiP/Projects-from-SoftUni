using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSystem
{
    abstract class Product
    {
        private string name;
        public string Name
        {
            get => this.name;
            set 
            {
                if (value.Length >= 3 && value.Length <= 30) this.name = value;
                else throw new ArgumentException("Name should be between 3 and 30 characters!");
            }
        }
        private double price;
        public double Price
        {
            get => this.price;
            set
            {
                if (value >= 0) this.price = value;
                else throw new ArgumentException("Price should be 0 or positive!");
            }
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Name: {this.Name}\nPrice: {this.Price}\n";
        }
    }
}
