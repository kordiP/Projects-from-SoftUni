using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Store
{
	private string name;

	public string Name
	{
		get { return name; }
		set 
		{ 
			if (value.Length == 0) throw new ArgumentException("Store name must not be null or empty!");
			name = value; 
		}
	}
	private string type;

	public string Type
	{
		get { return type; }
		set 
		{
            if (value.Length == 0) throw new ArgumentException("Store type must not be null or empty!");
            type = value; 
		}
	}
	private double revenue;

	public double Revenue
	{
		get { return revenue; }
		set { revenue = value; }
	}
	public Dictionary<string, Product> availableProducts;
	public Store(string name, string type)
	{
		Name = name;
		Type = type;
		availableProducts = new Dictionary<string, Product>();
    }
	public bool ReceiveProduct(Product product)
	{
		if (availableProducts.ContainsValue(product)) return false;

		availableProducts.Add(product.Name, product);
		return true;
	}
    public bool SellProduct(string name, int quantity)
	{
		if (availableProducts.ContainsKey(name) && availableProducts[name].Quantity >= quantity)
		{
            availableProducts[name].Quantity -= quantity;

            if (availableProducts[name].Quantity == 0) availableProducts.Remove(name);

			Revenue += quantity * availableProducts[name].FinalPrice;
			return true;
		}
		return false;
	}
	public Product GetProduct(string name)
	{
		if (availableProducts.ContainsKey(name)) return availableProducts[name];
		return null;
	}
	public override string ToString()
	{
		string returnThat = $"****Store: {Name} <{Type}>\n****Available products: <{availableProducts.Count}>\n";

		foreach (var item in availableProducts)
			returnThat += $"****** {item.Value.Name} ({item.Value.Quantity})\n";

		returnThat += $"****Revenue: <{Revenue:F2}BGN>\n";
		return returnThat;
	}
}