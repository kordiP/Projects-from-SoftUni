using System;

namespace masiv1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, min, max;
            Console.Write("Брой елементи на масива n=");
            n = int.Parse(Console.ReadLine());
            int[] masiv = new int[n];
            Console.WriteLine("Elementi na masiva:");
            masiv[0] = int.Parse(Console.ReadLine());
            max = masiv[0]; min = masiv[0];
            for (int i=1; i<n; i++)
            {
                masiv[i]= int.Parse(Console.ReadLine());
                if (max < masiv[i]) max = masiv[i];
                if (min > masiv[i]) min = masiv[i];
            }
            Console.WriteLine("max=" + max);
            Console.WriteLine("min=" + min);
            int brMax = 0, brMin = 0;
            for (int i = 1; i < n; i++)
            {
                if (max == masiv[i]) brMax++;
                if (min == masiv[i]) brMin++;
            }
            Console.WriteLine("brMax=" + brMax);
            Console.WriteLine("brMin=" + brMin);
        }
    }
}
