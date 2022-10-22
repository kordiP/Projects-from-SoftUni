using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class StoreController
{
    private Dictionary<string, Store> stores = new Dictionary<string, Store>();
    public string CreateStore(List<string> args)
    {
        if (stores.ContainsKey(args[0])) return $"Store {args[0]} is already registered!";
        Store store = new Store(args[0], args[1]);
        stores.Add(args[0], store);
        return $"Store {store.Name} was successfully registerd in the system!";
    }

    public string ReceiveProduct(List<string> args)
    {
        if (!stores.ContainsKey(args[5])) return $"Invalid Store: {args[5]}. Cannot find it in system!";
        if (stores[args[5]].availableProducts.ContainsKey(args[1])) return $"Product {args[1]} was already delivered to {args[5]}!";
            if (args[0] == "Food")
        {
            Food food = new Food(args[1], int.Parse(args[2]), double.Parse(args[3]), double.Parse(args[4]));
            stores[args[5]].ReceiveProduct(food);
        }
        else if (args[0] == "Drink")
        {
            Drink drink = new Drink(args[1], int.Parse(args[2]), double.Parse(args[3]), double.Parse(args[4]));
            stores[args[5]].ReceiveProduct(drink);
        }
        else return $"Product {args[0]} is invalid!";
        return $"Product {args[1]} was successfully delivered to {args[5]}!";
    }

    public string SellProduct(List<string> args)
    {
        if (!stores.ContainsKey(args[2])) return $"Invalid Store: {args[2]}. Cannot find it in system!";
        if (!stores[args[2]].availableProducts.ContainsKey(args[0])) return $"Product {args[0]} was already sold out!";
        stores[args[2]].SellProduct(args[0], int.Parse(args[1]));
        return $"Product {args[0]} was successfully bought from {args[2]}!";
    }

    public string StoreInfo(List<string> args)
    {
        if (!stores.ContainsKey(args[0])) return $"Invalid Store: {args[0]}. Cannot find it in system!";
        return stores[args[0]].ToString();
    }

    public string Shutdown()
    {
        string returnThat = $"Stores: {stores.Count}\n";
        foreach (var item in stores)
        {
            returnThat += item.Value;
        }
        returnThat += $"System Store Revenues: {stores.Values.Sum(x => x.Revenue):F2}BGN";
        return returnThat;
    }

}