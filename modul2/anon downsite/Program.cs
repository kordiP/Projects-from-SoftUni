using System;
using System.Numerics;
namespace anon_downsite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int SecurityKey = int.Parse(Console.ReadLine());
            decimal TotalLoss = 0;
            BigInteger SecurityToken = 1;
            for (int i = 0; i < N; i++)
            {
                string[] SiteInfo = Console.ReadLine().Split();
                Console.WriteLine(SiteInfo[0]); // Site name
                TotalLoss += decimal.Parse(SiteInfo[1]) * decimal.Parse(SiteInfo[2]);
                SecurityToken *= SecurityKey; 
            }
            Console.WriteLine($"Total Loss: {TotalLoss:F20}");
            Console.WriteLine($"Security Token: {SecurityToken}");
        }
    }
}
