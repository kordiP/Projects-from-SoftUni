using BillCalculator.Controllers;

namespace BillCalculator
{
    internal class Program
    {
        static void Main()
        {
            BillController billController = new BillController();
            billController.CalculateTotalBill();
        }
    }
}