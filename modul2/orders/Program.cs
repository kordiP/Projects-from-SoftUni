using System;
using System.Collections.Generic;
using System.Linq;
namespace orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string buyCommand = "buy";
            Dictionary<string, double> orders = new Dictionary<string, double>();        // name  | Total price
            Dictionary<double, double> productsInfo = new Dictionary<double, double>(); //  price | quantity
            string[] input = Console.ReadLine().Split();
            while (input[0] != buyCommand)
            {
                string name = input[0];
                double price = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);
                double totalCost = price * quantity;
                if (orders.ContainsKey(input[0]))
                {
                    productsInfo[price] = quantity;
                    double firstDuplicateQuantity = 0;
                    for (int i = 0; i < orders.Count; i++)
                        if (orders[name] / productsInfo.ElementAt(i).Key == productsInfo.ElementAt(i).Value) firstDuplicateQuantity = orders[name] / productsInfo.ElementAt(i).Key;
                        else continue;
                    Console.WriteLine(orders[name]);
                    quantity += firstDuplicateQuantity;
                    totalCost = price * quantity;
                    orders[name] = totalCost;
                }
                else
                {
                    orders[name] = totalCost;
                    productsInfo[price] = quantity;
                }
                input = Console.ReadLine().Split();
            }
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine($"{orders.ElementAt(i).Key} -> {orders.ElementAt(i).Value:F2}");
            }
        }
    }
}

