using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poloj__otric_i_nula_broqch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poloj = 0;
            int otric = 0;
            int nuli = 0;
            string chislo = Console.ReadLine();
            while (chislo != "end")
            {
                int chisloto = int.Parse(chislo);
                if (chisloto < 0)
                    otric++;
                else if (chisloto > 0)
                    poloj++;
                else if (chisloto == 0)
                    nuli++;
                chislo = Console.ReadLine();
            }
            Console.WriteLine("Broi na polojitelni: " + poloj);
            Console.WriteLine("Broi na otricatelni: " + otric);
            Console.WriteLine("Broi na nuli: " + nuli);
        }
    }
}
