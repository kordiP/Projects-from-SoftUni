using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alt_money
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double broi_BTC = double.Parse(Console.ReadLine());
            double nachalna_cena = double.Parse(Console.ReadLine());
            double tekushta_cena = double.Parse(Console.ReadLine());
            double broi_ET = double.Parse(Console.ReadLine());
            double broi_NEO = double.Parse(Console.ReadLine());
            double pechalba = (broi_BTC * tekushta_cena) - (broi_BTC * nachalna_cena);
            double cena_ETH = tekushta_cena * 0.075;
            double cena_NEO = cena_ETH * 0.4;
            double obshta_cena = (broi_ET * cena_ETH) + (broi_NEO * cena_NEO);
            if (pechalba >= obshta_cena) 
            {
                Console.WriteLine($"Stefcho bought {broi_ET:0.0000} Ethereum at a price of {cena_ETH:0.0000}");
                Console.WriteLine($"Stefcho bought {broi_NEO:0.0000} Neo at a price of {cena_NEO:0.0000}");
                Console.WriteLine($"Stefcho has {pechalba-obshta_cena:0.00} profits left to spend.");
            }
            else
            {
                Console.WriteLine("Stefcho does not have enough money to make this investment.");
                Console.WriteLine($"He needs {obshta_cena-pechalba:0.00} more in profits.");
            }
        }
    }
}
