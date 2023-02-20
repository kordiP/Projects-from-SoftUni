using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportPrice.Models;
using TransportPrice.View;

namespace TransportPrice.Controllers
{
    public class Controller
    {
        private Display display;
        private Vehicle vehicle;
        public Controller()
        {
            display = new Display();
        }

        public void Start()
        {
            int kilometres = display.Kilometres;
            string shift = display.DayOrNight;
            if (kilometres < 20)
            {
                vehicle= new Taxi();
            }
            else if (kilometres < 100)
            {
                vehicle = new Bus();
            }
            else
            {
                vehicle = new Train();
            }
            decimal totalPrice = vehicle.CalculateTrip(kilometres, shift);
            display.Model = new PriceViewModel(totalPrice);
            display.Print();
        }
    }
}
