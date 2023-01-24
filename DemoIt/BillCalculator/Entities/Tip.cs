using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCalculator.Entities
{
    public class Tip
    {
        private decimal amount;
        private double percent;
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public double Percent
        {
            get { return percent; }
            set { percent = value; }
        }
        public Tip(decimal amount, double percent)
        {
            Amount = amount;
            Percent = percent;
        }
        public Tip() : this(0, 0) { }

        public decimal CalculateTip()
        {
            return Amount * (decimal)Percent / 100;
        }

    }
}
