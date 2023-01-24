using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillCalculator.Entities;
using BillCalculator.Views;

namespace BillCalculator.Controllers
{
    public class BillController
    {
        private Tip tip;
        private Display display;
        public BillController()
        {
            tip = new Tip();
            display = new Display();
        }

        public void CalculateTotalBill()
        {
            display.GetValues();
            tip.Amount = display.BillAmount;
            tip.Percent = display.Percent;
            display.TipAmount = tip.CalculateTip();
            display.TotalBillAmount = display.BillAmount + display.TipAmount;
            display.Result();
        }
    }
}
