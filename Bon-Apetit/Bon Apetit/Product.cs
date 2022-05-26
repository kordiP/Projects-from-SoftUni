using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bon_Apetit
{
    internal class Product
    {
        private string name;
        public string Name
        {
            get { return name; }
            set 
            {
                if (value.Length > 3)
                    name = value;
                else
                    Console.WriteLine("Invalid Command!");
            }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set 
            {
                if (value >= 0.01)
                    price = value;
                else
                    Console.WriteLine("Invalid Command!");
            }
        }
        private int weight;
        public int Weight
        {
            get { return weight; }
            set 
            {
                if (value > 0)
                    weight = value;
                else Console.WriteLine("Invalid Command!");
            }
        }
        public Product(string name, double price, int weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
        public static Product GetCheapestProduct(Dictionary<string, Product> products)
        {
            return products.OrderBy(x => x.Value.Price).First().Value;
        }

        public override string ToString()
        {
            return $"{name} - {weight}";
        }
    }
}
