using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ShoppingSystem
{
    internal class Controller
    {
        List<Product> currentCustomersProduct = new List<Product>();
        Dictionary<string, Receipt> receipts = new Dictionary<string, Receipt>();
        public string ProcessProductCommand(List<string> args)
        {
            PhysicalProduct physicalProduct = new PhysicalProduct(args[1], double.Parse(args[2]), double.Parse(args[3]));
            currentCustomersProduct.Add(physicalProduct);
            return $"The current customer has bought {physicalProduct.Name}.";
        }

        public string ProcessServiceCommand(List<string> args)
        {
            ServiceProduct serviceProduct = new ServiceProduct(args[1], double.Parse(args[2]), double.Parse(args[3]));
            currentCustomersProduct.Add(serviceProduct);
            return $"The current customer has applied for {serviceProduct.Name} service.";
        }

        public string ProcessCheckoutCommand(List<string> args)
        {
            Receipt receipt = new Receipt(args[1]);
            for (int i = 0; i < currentCustomersProduct.Count; i++)
            {
                receipt.AddProduct(currentCustomersProduct[i]);
            }
            receipts.Add(args[1], receipt);
            currentCustomersProduct.Clear();
            return $"Customer checked out for a total of ${receipt.sumOfProducts:F2}.";
            }

        public string ProcessInfoCommand(List<string> args)
        {
            string returnThat = "";
            double sumOfCurrentPorducts = 0;
            if (args[1] == "Customer")
            {
                foreach (var item in currentCustomersProduct) sumOfCurrentPorducts += item.Price;
                returnThat += $"Current customer has: \nProducts: {currentCustomersProduct.Count}\nTotal bill: ${sumOfCurrentPorducts:F2}";
            }
            else if (args[1] == "Shop")
            {
                returnThat += "Receipts: \n";
                if (receipts.Count < 1) returnThat += "No receipts";
                foreach (var receipt in receipts) returnThat += receipt.Value.ToString();
            }
            return returnThat;
        }
        public string ProcessEndCommand()
        {
            string returnThat = $"Total customers today: {receipts.Count}";
            return returnThat;
        }

    }
}