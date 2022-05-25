using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banica
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;
            Console.Write("Vuvedi cena na edna banica: ");
            double cena = double.Parse(Console.ReadLine());           
            Console.Write("Kolko banici iskate da kupite? ");
            int banica = int.Parse(Console.ReadLine());
            double lev = (banica * cena);
            
            c = Math.Floor(lev);
            double stotinki = (lev-c)*100;
            Console.WriteLine("Trqbvat {0} leva i {1} stotinki" ,c,stotinki);

        }
    }
}
