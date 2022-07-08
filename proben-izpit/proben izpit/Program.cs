string model = Console.ReadLine();
double cena = double.Parse(Console.ReadLine());
int dni = int.Parse(Console.ReadLine());
double danuci = 20 * cena / 100 + 275 + cena + (dni * 20);
double profit = 15 * danuci / 100;
double d2 = danuci + profit;
Console.WriteLine($"The {model} with initial price of {cena.ToString("0.00")} BGN will sell for {d2.ToString("#.##")} BGN");
Console.WriteLine($"Profit: {profit.ToString ("0.##")} BGN");