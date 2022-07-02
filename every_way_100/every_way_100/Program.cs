using System;
namespace every_way_100

{
    class Program
    {
        static void Main()
        {
            double target = 100.00;
            double[] allMoney = { 100.00, 50.00, 20.00, 10.00, 5.00, 2.00, 1.00, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 };
            int wayCounter = 0;
            for (double i = 0; i <= target / allMoney[allMoney.Length - 13]; i += 1)
                for (double j = 0; j <= target / allMoney[allMoney.Length - 12]; j += 1)
                    for (double y = 0; y <= target / allMoney[allMoney.Length - 11]; y += 1)
                        for (double k = 0; k <= target / allMoney[allMoney.Length - 10]; k += 1)
                            for (double a = 0; a <= target / allMoney[allMoney.Length - 9]; a += 1)
                                for (double s = 0; s <= target / allMoney[allMoney.Length - 8]; s += 1)
                                    for (double d = 0; d < target / allMoney[allMoney.Length - 7]; d += 1)
                                        for (double g = 0; g <= target / allMoney[allMoney.Length - 6]; g += 1)
                                            for (double h = 0; h <= target / allMoney[allMoney.Length - 5]; h += 1)
                                                for (double z = 0; z <= target / allMoney[allMoney.Length - 4]; z += 1)
                                                    for (double x = 0; x <= target / allMoney[allMoney.Length - 3]; x += 1)
                                                        for (double c = 0; c <= target / allMoney[allMoney.Length - 2]; c += 1)
                                                            for (double f = 0; f <= target / allMoney[allMoney.Length - 1]; f += 1)
                                                                if (i * 100 + j * 50 + y * 20 + k * 10 + a * 5 + s * 2 + d + f / 2 + g / 5 + h / 10 + z / 20 + x / 50 + c / 100 == target)
                                                                {
                                                                    wayCounter++;
                                                                    Console.WriteLine($"{i}x100.0 {j}x0.02 {y}x0.05 {k}x0.10 {a}x0.20 {s}x0.50 {d}x1.00 {g}x2.00 {h}x5.00 {z}x10.00 {x}x20.00 {c}x50.00 {f}0x0.01");
                                                                    i = 0; j = 0; y = 0; k = 0; a = 0;s = 0; d = 0; f = 0; g = 0; h = 0; z = 0; x = 0; c = 0; f = 0;
                                                                }
            Console.WriteLine(wayCounter);
        }
    }
}
