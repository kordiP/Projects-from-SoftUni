// See https://aka.ms/new-console-template for more information
using System;

double n = int.Parse(Console.ReadLine());
    Console.Write("/");
    for (int p = 0; p < Math.Floor(n / 2); p++)
    {
        Console.Write("^");
    }
    Console.Write("\\");
    if (n > 4)
    {
        for (int m = 0; m < 2 * n - 2 * Math.Floor(n / 2) - 4; m++)
        {
            Console.Write("_");
        }
    }
Console.Write("/");
for (int p = 0; p < Math.Floor(n / 2); p++)
{
    Console.Write("^");
}
Console.Write("\\");
Console.WriteLine();
for (int i = 0; i < n - 3; i++)
{
    Console.Write("|");
    if (n == 4)
    {
        for (int j = 0; j < n + Math.Floor(n / 2); j++)
        {
            Console.Write(" ");
        }
    }
    else if (n == 3)
    {
        for (int j = 0; j <= n + Math.Floor(n / 2) + 1; j++)
        {
            Console.Write(" ");
        }
    }
    else
    {
        for (int j = 1; j <= Math.Floor(n / 2) + 1 + 2 * n - 2 * Math.Floor(n / 2) - 4 + Math.Floor(n / 2) + 1; j++)
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine("|");
}
Console.Write("|");
if (n>4)
{
    for (int i = 1; i <= Math.Floor(n / 2) + 1; i++) 
    {
        Console.Write(" ");
    }
    for (int m = 0; m < 2 * n - 2 * Math.Floor(n / 2) - 4; m++)
    {
        Console.Write("_");
    }
    for (int i = 1; i <= Math.Floor(n / 2) + 1; i++)
    {
        Console.Write(" ");
    }
}
else
{
    for (int i = 1; i < n + Math.Floor(n / 2) + 1; i++)
    {
        Console.Write(" ");
    }
}
Console.WriteLine("|");
Console.Write("\\");
    for (int g = 0; g < Math.Floor(n / 2); g++)
    {
        Console.Write("_");
    }
    Console.Write("/");
if (n > 4)
{
    for (int m = 0; m < 2 * n - 2 * Math.Floor(n / 2) - 4; m++)
    {
        Console.Write(" ");
    }
}
Console.Write("\\");
for (int g = 0; g < Math.Floor(n / 2); g++)
{
    Console.Write("_");
}
Console.Write("/");

