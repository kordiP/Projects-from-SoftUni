using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FruitsAndVeggies.Views
{
    public class Display
    {
        public double VeggiePrice { get; set; }
        public double FruitPrice { get; set; }
        public int VeggieWeight { get; set; }
        public int FruitWeight { get; set; }
        public double TotalSum { get; set; }
        public Display()
        {
            VeggiePrice = 0;
            FruitPrice = 0;
            VeggieWeight = 0;
            FruitWeight = 0;
            TotalSum = 0;
        }
        public void GetValues()
        {
            VeggiePrice = double.Parse(Console.ReadLine());
            FruitPrice = double.Parse(Console.ReadLine());
            VeggieWeight = int.Parse(Console.ReadLine());
            FruitWeight = int.Parse(Console.ReadLine());
        }
        public void ShowTotal()
        {
            Console.WriteLine(TotalSum);
        }
    }
}
