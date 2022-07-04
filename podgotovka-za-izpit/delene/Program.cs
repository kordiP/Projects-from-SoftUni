// See https://aka.ms/new-console-template for more information
uint n = uint.Parse(Console.ReadLine());
double b1=0;
double b2=0;
double b3=0;
for (int i = 0; i < n; i++)
{
    int chislo = int.Parse(Console.ReadLine());
    if (chislo % 2 == 0)
    {
        b1++;
    }
    if (chislo % 3 == 0)
    {
        b2++;
    }
    if (chislo % 4 == 0)
    {
        b3++;
    }
}
Console.Write(string.Format("{0:F2}", b1 / n * 100));
Console.WriteLine("%");
Console.Write(string.Format("{0:F2}", b2 / n * 100));
Console.WriteLine("%");
Console.Write(string.Format("{0:F2}", b3 / n * 100));
Console.WriteLine("%");
