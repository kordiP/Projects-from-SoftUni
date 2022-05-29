using System;
using System.Collections.Generic;

class Product
{
    public string Name;
    public double Price;
    public int Quantity;

    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        Dictionary<string, Product> articles = new Dictionary<string, Product>();

        while (input[0] != "stocked")
        {
            string name = input[0];
            double price = double.Parse(input[1]);
            int quantity = int.Parse(input[2]);
            if (!articles.ContainsKey(name))
                articles[name] = new Product(name, price, quantity);

            else
            {
                articles[name].Price = price;
                articles[name].Quantity += quantity;
            }
            input = Console.ReadLine().Split();
        }

        double grandTotal = 0;
        foreach (var article in articles)
        {
            double total = article.Value.Price * article.Value.Quantity;
            Console.WriteLine($"{article.Key}: ${article.Value.Price:f2} * {article.Value.Quantity} = ${total:f2}");
            grandTotal += total;
        }
        Console.WriteLine(new string('-', 30));

        // double grandTotal = articles.Sum(x => x.Value.Key * x.Value.Value); // Linq Grand Total

        Console.WriteLine($"Grand Total: ${grandTotal:f2}");
    }
}
