using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Drink : Product
{
    public override double PercentageMarkup
    {
        get => base.PercentageMarkup;
        set
        {
            if (value <= 200) base.PercentageMarkup = value;
            else throw new ArgumentException("Drink percentage markup cannot be above 200%!");
        }
    }
    public Drink(string name, int quantity, double deliverPrice, double percentageMarkup) : base(name, quantity, deliverPrice, percentageMarkup)
    {
        base.Name = name;
        base.Quantity = quantity;
        base.DeliverPrice = deliverPrice;
        base.PercentageMarkup = percentageMarkup;
    }
}