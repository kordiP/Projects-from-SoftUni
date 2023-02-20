using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice.Models
{
    public abstract class Vehicle
    {
        public decimal DayRate { get; set; }
        public decimal NightRate { get; set; }
        public Vehicle(decimal dayRate, decimal nightRate)
        {
            DayRate = dayRate;
            NightRate = nightRate;
        }

        public virtual decimal CalculateTrip(int kilometres, string dayOrNight)
        {
            if (dayOrNight == "day")
            {
                return DayRate * kilometres;
            }
            else
            {
                return NightRate * kilometres;
            }
        }
    }
}
