int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n - 2; i++) 
{
    if (i % 2 != 0) 
    {
        Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
    }
    else
    {
        Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
    }
}
Console.WriteLine($"{new string(' ', n-2)} {"@"}");
for (int i = 1; i <= n - 2; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
    }
    else
    {
        Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
    }
}