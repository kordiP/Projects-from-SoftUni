using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitsAndVeggies.Models;
using FruitsAndVeggies.Views;

namespace FruitsAndVeggies.Controllers
{
    public class PriceCalculateController
    {
        private Display display;
        private Fruits fruits;
        private Veggies veggies;
        public PriceCalculateController()
        {
            // Read user input
            display= new Display();
            display.GetValues();

            fruits = new Fruits(display.FruitPrice, display.FruitWeight);
            veggies = new Veggies(display.VeggiePrice, display.VeggieWeight);
            // Transfer data
            display.TotalSum = 
                (double)fruits.CalculateFruitPriceEuro() +
                (double)veggies.CalculateVeggiePriceEuro();

            display.ShowTotal();
        }
    }
}
