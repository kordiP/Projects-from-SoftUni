int N = int.Parse(Console.ReadLine());
int SecurityKey = int.Parse(Console.ReadLine());
decimal TotalLoss = 0;
    for (int i = 0; i < N; i++)
    {
        string[] SiteInfo = Console.ReadLine().Split();
        Console.WriteLine(SiteInfo[0]); // Site name
        TotalLoss += decimal.Parse(SiteInfo[1]) * decimal.Parse(SiteInfo[2]);
    }
Console.WriteLine($"Total Loss: {TotalLoss:F20}");
Console.WriteLine($"Security Token: {Math.Pow(SecurityKey, N)}");