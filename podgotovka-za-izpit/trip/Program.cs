// See https://aka.ms/new-console-template for more information
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
if (budget <= 100)
{
    if (season == "summer")
    {
        Console.WriteLine("Somewhere in Bulgaria");
        Console.WriteLine($"Camp - {string.Format("{0:F2}", budget * 30 / 100, 2)}"); 
    }
    else
    {
        Console.WriteLine("Somewhere in Bulgaria");
        Console.WriteLine($"Hotel - {string.Format("{0:F2}", budget * 70 / 100, 2)}");
    }
}
if (budget <= 1000 && budget > 100)
{
    if (season == "summer")
    {
        Console.WriteLine("Somewhere in Balkans");
        Console.WriteLine($"Camp - {string.Format("{0:F2}", budget * 40 / 100, 2)}");
    }
    else
    {
        Console.WriteLine("Somewhere in Balkans");
        Console.WriteLine($"Hotel - {string.Format("{0:F2}", budget * 80 / 100, 2)}");
    }
}
if (budget > 1000)
{
    if (season == "summer")
    {
        Console.WriteLine("Somewhere in Europe");
        Console.WriteLine($"Hotel - {string.Format("{0:F2}", budget * 90 / 100, 2)}");
    }
    else
    {
        Console.WriteLine("Somewhere in Europe");
        Console.WriteLine($"Hotel - {string.Format("{0:F2}", budget * 90 / 100, 2)}");
    }
}