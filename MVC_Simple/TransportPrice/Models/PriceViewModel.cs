using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace TransportPrice.Models
{
    public class PriceViewModel
    {
        public decimal Price { get; set; }
        public PriceViewModel(decimal price)
        {
            Price = price;
        }
    }
}
