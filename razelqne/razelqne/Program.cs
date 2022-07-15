using System;

namespace razelqne
{
    class Program
    {
        static void Main(string[] args)
        {
            //int chislo = int.Parse(Console.ReadLine());
            //int m = chislo / 10;
            //int d = m % 10;
            //int parvo = chislo / 100;
            //int vtoro = d;
            //int treto = chislo % 10;
            //Console.WriteLine(parvo);
            //Console.WriteLine(vtoro);
            //Console.WriteLine(treto);
            Console.WriteLine("V kolko chasa izlita?");
            int h =int.Parse(Console.ReadLine());
            int m =int.Parse(Console.ReadLine());
            Console.WriteLine("Kolko chasa i minuti trae?");
            int h1 =int.Parse(Console.ReadLine());
            int m1 =int.Parse(Console.ReadLine());
            int m2 = m + m1;
            int h2 = h + h1+m2/60;
            m2 = m2 % 60;
            h2 = h2 % 24;          
            Console.WriteLine("Samoletat kaca vav " + h2 + ":" + m2 + ".");



        }
    }
}
