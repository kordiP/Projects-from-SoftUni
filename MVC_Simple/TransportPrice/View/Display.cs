using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportPrice.Models;

namespace TransportPrice.View
{
    public class Display
    {
        public int Kilometres { get; set; }
        public string DayOrNight { get; set; }
        public PriceViewModel Model { get; set; }
        public Display()
        {
            GetValues();
        }
        private void GetValues()
        {
            Kilometres = int.Parse(Console.ReadLine());
            DayOrNight = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine(Model.Price);
        }
    }
}
