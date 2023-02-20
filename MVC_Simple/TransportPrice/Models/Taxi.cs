using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice.Models
{
    public class Taxi : Vehicle
    {
        private const decimal startCharge = 0.70M;
        private const decimal dayRate = 0.79M;
        private const decimal nightRate = 0.90M;
        public Taxi()
            :base(dayRate, nightRate)
        {
        }
        public override decimal CalculateTrip(int kilometres, string dayOrNight)
        {
            return base.CalculateTrip(kilometres, dayOrNight) + startCharge;
        }
    }
}
