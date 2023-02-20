using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice.Models
{
    public class Train : Vehicle
    {
        private const decimal rate = 0.06M;
        public Train()
            :base (rate, rate)
        {
        }
    }
}
