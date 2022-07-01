using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obmenno_buro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valuta = Console.ReadLine();
            double evro = double.Parse(Console.ReadLine());
            if (valuta == "XRP")
            {
                if (evro > 1000)
                {
                    evro = 1.1 * evro;
                    double XRP = evro / 0.22;
                    if (XRP < 80)
                    {
                        Console.WriteLine("Insufficient funds");
                    }
                    else if (XRP > 1000 && XRP < 2500)
                    {
                        XRP = 1.05 * XRP;
                        Console.WriteLine($"Successfully purchased {XRP:0.000} XRP");
                    }
                    else if (XRP >= 2500)
                    {
                        XRP = 1.1 * XRP;
                        Console.WriteLine($"Successfully purchased {XRP:0.000} XRP");
                    }
                }
                else
                {
                    double XRP = evro / 0.22;
                    if (XRP < 80)
                    {
                        Console.WriteLine("Insufficient funds");
                    }
                    else if (XRP > 1000 && XRP < 2500)
                    {
                        XRP = 1.05 * XRP;
                        Console.WriteLine($"Successfully purchased {XRP:0.000} XRP");
                    }
                    else if (XRP >= 2500)
                    {
                        XRP = 1.1 * XRP;
                        Console.WriteLine($"Successfully purchased {XRP:0.000} XRP");
                    }
                    else
                    {
                        Console.WriteLine($"Successfully purchased {XRP:0.000} XRP");
                    }
                }
            }
            else if (valuta == "ETH")
            {
                double ETH = evro / 250;
                if (evro > 1000)
                {
                    evro = evro * 0.1 + evro;
                    ETH = evro / 250;
                    Console.WriteLine($"Successfully purchased {ETH:0.000} ETH");
                }
                else if (ETH > 0.0099)
                {
                    ETH = evro / 250;
                    Console.WriteLine($"Successfully purchased {ETH:0.000} ETH");
                }
                else
                {
                    Console.WriteLine("Insufficient funds");
                }
            }
            else if (valuta == "BTC")
            {
                double BTC = evro / 6400;
                if (evro > 1000)
                {
                    if (BTC > 10)
                    {
                        evro = evro * 0.1 + evro;
                        BTC = evro / 6400;
                        BTC = BTC * 0.02 + BTC;
                        Console.WriteLine($"Successfully purchased {BTC:0.000} BTC");
                    }
                    else if (BTC < 0.001)
                    {
                        Console.WriteLine("Insufficient funds");

                    }
                    else
                    {
                        evro = evro * 0.1 + evro;
                        BTC = evro / 6400;
                        Console.WriteLine($"Successfully purchased {BTC:0.000} BTC");
                    }
                }
                else
                {
                    if (BTC > 10)
                    {
                        BTC = evro / 6400;
                        BTC = BTC * 0.02 + BTC;
                        Console.WriteLine($"Successfully purchased {BTC:0.000} BTC");
                    }
                    else if (BTC < 0.001)
                    {
                        Console.WriteLine("Insufficient funds");

                    }
                    else
                    {
                        BTC = evro / 6400;
                        Console.WriteLine($"Successfully purchased {BTC:0.000} BTC");
                    }

                }
            }
            else
            {
                Console.WriteLine($"EUR to {valuta} is not supported.");
            }
        }
    }
}
