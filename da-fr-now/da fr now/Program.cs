using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace da_fr_now
{
    class Program
    {
        static void Main(string[] args)
        {
            double cena_1_kv = double.Parse(Console.ReadLine());
            double shirina = double.Parse(Console.ReadLine());
            double duljina = double.Parse(Console.ReadLine());
            double cena_podlojka = double.Parse(Console.ReadLine());
            double plosht = duljina * shirina;
            double cena = cena_1_kv * plosht;
            double podlojka_krai = cena_podlojka * plosht;
            double montaj = (cena + podlojka_krai) * 0.4;
            double obshto = cena + podlojka_krai + montaj;
            Console.WriteLine($"{obshto:0.00}");
        }
    }
}
