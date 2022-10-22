using System;

public abstract class Product
{
	private string name;

	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			if (value.Length == 0) throw new ArgumentException("Product name must not be null or empty!");
			name = value;
		}
	}
    private int quantity;

    public int Quantity
    {
        get
        {
            return quantity;
        }
        set
        {
            if (value <= 0) throw new ArgumentException("Quantity cannot be less or equal to 0!");
            quantity = value;
        }
    }
	private double deliverPrice;

	public double DeliverPrice
    {
		get { return deliverPrice; }
		set 
		{
            if (value <= 0) throw new ArgumentException("Deliver price cannot be less or equal to 0!");
            deliverPrice = value; 
		}
	}
	private double percentageMarkup;

	public virtual double PercentageMarkup
    {
		get { return percentageMarkup; }
		set 
		{
            if (value <= 0) throw new ArgumentException("Percentage markup cannot be less or equal to 0!");
            percentageMarkup = value; 
		}
	}
    public double FinalPrice
    {
        get 
		{ 
			return DeliverPrice + (DeliverPrice * PercentageMarkup / 100);
        }
    }
	public Product(string name, int quantity, double deliverPrice, double percentageMarkup)
	{
		Name = name;
		Quantity = quantity;
		DeliverPrice = deliverPrice;
		PercentageMarkup = percentageMarkup;
	}
	public override string ToString()
	{
		return $"****Product: {Name} <{Quantity}>\n****Deliver Price: {DeliverPrice}\n****Percentage Markup: {PercentageMarkup}\n****Final Price: {FinalPrice}\n";
	}
}