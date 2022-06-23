using System;
using System.Collections.Generic;
namespace supermarket
{
    class Product
    {
        public string name;
        public double price;
        public int quantity;
        public Product()
        {

        }
        public Product(string name, double price, int quantity)
        {

        }
    }
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            Product product1 = new Product();
            product1.name = "Beer";
            product1.price = 1.50;
            product1.quantity = 1;
            products.Add(product1.name, product1);

            Product product2 = new Product("Cheese", 3.80, 2);
        }
    }
}
