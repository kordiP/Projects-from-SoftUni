using System.Collections.Generic;
using System;
using System.Linq;
namespace Bon_Apetit
{
    internal class Meal
    {
        private string name;
        private string type;
        private List<Product> products = new List<Product>();
        private int ordered;
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
        public string Type
        {
            get { return type; }
            set
            {
                if (value != null)
                    type = value;
                else
                    Console.WriteLine("Invalid Command!");
            }
        }
        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
        public int Ordered
        {
            get { return ordered; }
            set { ordered = value; }
        }
        public double Price
        {
            get
            {
                return products.Sum(x => x.Price * 1.3);           
            }
        }
        public Meal(string name, string type)
        {
            Name = name;
            Type = type;
        }
        public Meal(string name, string type, List<Product> products)
        {
            Name = name;
            Type = type;
            Products = products;
        }
        public void AddProduct(Product p)
        {
            Products.Add(p);
        }

        public bool ContainsProduct(string name)
        {
            Product p = products.Find(x => x.Name == name);
            if (p != null)
                return true;
            else return false;
        }

        public void PrintRecipe()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(Name + " RECIPE");
            Console.WriteLine("-------------------------");
            Console.WriteLine(String.Join("\n", products));
            Console.WriteLine("-------------------------");
        }

        public void Order()
        {
            Ordered++; 
        }

        public static Meal GetSpecialty(Dictionary<string, Meal> meals)
        {
            return meals.OrderByDescending(x => x.Value.Ordered).First().Value;
        }

        public static Meal RecommendByPrice(double price, Dictionary<string, Meal> meals)
        {
            string reccomended = meals.Keys.First();
            double topDiff = double.MaxValue;   // smallest diff
            foreach (var meal in meals)
            {
                double curDiff = price - meal.Value.Price;
                if (curDiff >= 0 && curDiff < topDiff)
                {
                    topDiff = curDiff;
                    reccomended = meal.Key;
                }
            }
            return meals[reccomended];
        }

        public static Meal RecommendByPriceAndType(double price, string type, Dictionary<string, Meal> meals)
        {
            string reccomended = meals.Keys.First();
            double topDiff = double.MaxValue;   // smallest diff
            foreach (var meal in meals)
            {
                double curDiff = price - meal.Value.Price;
                if (curDiff >= 0 && curDiff < topDiff && meal.Value.Type == type)
                {
                    topDiff = curDiff;
                    reccomended = meal.Key;
                }
            }
            return meals[reccomended];
        }
        public override string ToString()
        {
            return $"{Name} - {Type}";
        }
    }
}
