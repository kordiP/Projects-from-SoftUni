using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Duljina na ploshtadka N=");
            double N = double.Parse(Console.ReadLine());
            double S1 = N * N;
            Console.Write("Duljina na plochka W=");
            double W = double.Parse(Console.ReadLine());
            Console.Write("L=");
            double L = double.Parse(Console.ReadLine());
            double S2 = W * L;
            Console.Write("Shirochina na peika M=");
            double M = double.Parse(Console.ReadLine());
            Console.Write("Duljina na peika O=");
            double O = double.Parse(Console.ReadLine());
            double S3 = M * O;
            Console.WriteLine("Speika e ravno na " + S3);
            Console.WriteLine("Sploshtadka e ravno na " + S1);
            Console.WriteLine("Splochka e ravno na " + S2);
            double PloshtPokrivane = S1 - S3;
            double PlochkiZaPokrivane = (S1 - S3) / S2;
            double VremeZaSlagane = PlochkiZaPokrivane * 0.2;
            Console.WriteLine("Neobhodimi plochki=" + PlochkiZaPokrivane);
            Console.Write("Neobhodimo vreme=" + VremeZaSlagane);
        }
    }
}
