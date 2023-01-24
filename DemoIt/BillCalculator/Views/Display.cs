using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCalculator.Views
{
    public class Display
    {
        private decimal billAmount;

        public decimal BillAmount
        {
            get { return billAmount; }
            set { billAmount = value; }
        }
        private decimal tipAmount;

        public decimal TipAmount
        {
            get { return tipAmount; }
            set { tipAmount = value; }
        }
        private decimal totalBillAmount;

        public decimal TotalBillAmount
        {
            get { return totalBillAmount; }
            set { totalBillAmount = value; }
        }
        private double percent;
        public double Percent
        {
            get { return percent; }
            set { percent = value; }
        }
        public Display()
        {
            BillAmount = 0;
            TipAmount = 0;
            TotalBillAmount = 0;
            Percent = 0;
        }
        public void GetValues()
        {
            Console.WriteLine($"The bill is:");
            BillAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"The percent for the tip is:");
            Percent = double.Parse(Console.ReadLine());
        }
        public void Result()
        {
            Console.WriteLine($"The bill is: {BillAmount}.\nThe tip is: {TipAmount}.\nThe total bill is: {TotalBillAmount}.");
        }
    }
}
