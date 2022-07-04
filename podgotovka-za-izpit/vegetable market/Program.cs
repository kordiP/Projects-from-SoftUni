// See https://aka.ms/new-console-template for more information
double n = double.Parse(Console.ReadLine());  //zelenchuci cena
double m = double.Parse(Console.ReadLine());  //plodove cena
double k1 = double.Parse(Console.ReadLine());  //zelenchuci kg
double k2 = double.Parse(Console.ReadLine());  //plodove kg
Console.WriteLine(((n * k1) + (m * k2)) / 1.94);
