using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSystem
{
    internal class Receipt
    {
        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if (value.Length >= 2 && value.Length <= 40) customerName = value;
                else throw new ArgumentException("Customer Name should be between 2 and 40 characters!");
            }
        }
        public Dictionary<string, Product> products;
        public double sumOfProducts = 0;
        public Receipt(string customerName)
        {
            this.CustomerName = customerName;
            products = new Dictionary<string, Product>();
        }
        public void AddProduct(Product product)
        {
            products.Add(product.Name, product);
            sumOfProducts += product.Price;
        }
        public override string ToString()
        {
            string returnThat = $"Receipt of {this.CustomerName}\nTotal price: {this.sumOfProducts:F2}\nProducts: \n";
            foreach (var item in products)
            {
                returnThat += item.Value.ToString();
            }
            return returnThat;
        }
    }
}
