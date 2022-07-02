using System;
using System.Collections.Generic;
using System.Linq;
namespace imena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете списък с имена, разделени с ; :");
            List<string> imena = Console.ReadLine().Split(';').ToList();

            foreach(var ime in imena)
                Console.WriteLine(ime);

            Console.WriteLine("Въведи ново име и фамилия за добавяне към списъка:");
            var nov = Console.ReadLine();
            int posicia;
            do
            {
                Console.Write("Въведи позиция за вмъкване на новото име: ");
                posicia = int.Parse(Console.ReadLine());
            } while (posicia < 0 || posicia > imena.Count);
            imena.Insert(posicia, nov);
            Console.WriteLine("Нов списък: ");
            Console.WriteLine(string.Join(", ", imena));
        }
    }
}
