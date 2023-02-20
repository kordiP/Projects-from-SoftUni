using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsAndVeggies.Models
{
    public class Fruits
    {
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Fruits(double price, int weight)
        {
            this.Price = price;
            this.Weight = weight;
        }
        public double CalculateFruitPriceEuro()
        {
            return Price * Weight / 1.94;
        }
    }
}
