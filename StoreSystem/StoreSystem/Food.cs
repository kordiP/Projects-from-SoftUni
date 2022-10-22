using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Food : Product
{
    public override double PercentageMarkup 
    {
        get => base.PercentageMarkup; 
        set 
        {
            if (value <= 100) base.PercentageMarkup = value;
            else throw new ArgumentException("Food percentage markup cannot be above 100%!");
        }
    }
    public Food(string name, int quantity, double deliverPrice, double percentageMarkup) : base(name, quantity, deliverPrice, percentageMarkup)
    {
        base.Name = name;
        base.Quantity = quantity;
        base.DeliverPrice = deliverPrice;
        base.PercentageMarkup = percentageMarkup;
    }
}