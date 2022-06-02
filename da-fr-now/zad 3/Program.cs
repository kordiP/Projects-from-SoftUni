using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double shirina = double.Parse(Console.ReadLine());
            double duljina = double.Parse(Console.ReadLine());
            int kameri = int.Parse(Console.ReadLine());
            string firma = Console.ReadLine();
            double razmeri = duljina * shirina;
            double cena_kam = 0;
            if (firma == "Dogramichka4You")
            {
                if (kameri==3)
                {
                    cena_kam = 12;
                }
                else if (kameri==4)
                {
                    cena_kam = 15;
                }
                else
                {
                    cena_kam = 20;
                }
            }
            else if (firma == "ChukChuk")
            {
                if (kameri == 3)
                {
                    cena_kam = 14;
                }
                else if (kameri == 4)
                {
                    cena_kam = 20;
                }
                else
                {
                    cena_kam = 22;
                }
            }
            else if (firma=="TihoToplo")
            {
                if (kameri == 3)
                {
                    cena_kam = 15;
                }
                else if (kameri == 4)
                {
                    cena_kam = 14;
                }
                else
                {
                    cena_kam = 18;
                }
            }
            double razhod = razmeri * cena_kam;
            Console.WriteLine($"Goshko has to spend {razhod:0.00} leva.");
        }
    }
}
