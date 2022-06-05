using System;
using System.Collections.Generic;
using System.Linq;

namespace dr_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Брой елементи в списъка n= ");
            int n = int.Parse(Console.ReadLine());

            List<double> chisla = new List<double>();
            Console.WriteLine("Елементи на списъка (дробни числа):");
            for(int i=0;i<n;i++)
            {
                Console.Write("Елемент {0} = ", i);
                chisla.Add(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Списъкът е:");
            foreach(double x in chisla)
                Console.WriteLine(x);

            Console.WriteLine("Сортиран списък - възходящ ред:");
            chisla.Sort();
            foreach (double x in chisla)
                Console.WriteLine(x);

            Console.WriteLine("Сортиран списък - низходящ ред:");
            chisla.Reverse();
            foreach (double x in chisla)
                Console.WriteLine(x);

            Console.WriteLine("Минимален елемент в списъка Min= "+chisla.Min());
            Console.WriteLine("Максимален елемент в списъка Min= " + chisla.Max());

        }
    }
}
