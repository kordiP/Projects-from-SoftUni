using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obmen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double bitcoin_price = double.Parse(Console.ReadLine());
            int satoshi = int.Parse(Console.ReadLine());
            double bitcoin = money / bitcoin_price;
            double tax1 = bitcoin * (satoshi * 1024) / 100000000;
            double kraen_bitcoin = bitcoin - tax1;
            double zaplata = kraen_bitcoin * 0.1;
            double print_bitcoin = kraen_bitcoin - zaplata;
            double tax = tax1 * bitcoin_price;
            Console.WriteLine($"Total bitcoin after expenses: {print_bitcoin:0.00000} BTC");
            Console.WriteLine($"Tax payed: {tax:0.00} USD");
            Console.WriteLine($"Programmer`s payment: {zaplata:0.00000} BTC");
        }
    }
}
