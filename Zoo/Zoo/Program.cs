using System;

namespace Zoo
{
    internal class Program
    {
        static void Main()
        {
            string gorillaName = Console.ReadLine();
            Gorilla gorilla= new Gorilla(gorillaName);
            string snakeName = Console.ReadLine();
            Snake snake = new Snake(snakeName);
            string lizardName = Console.ReadLine();
            Lizard lizard = new Lizard(lizardName);
            string bearName = Console.ReadLine();
            Bear bear = new Bear(bearName); //(Kris Mechonito)
            Console.WriteLine($"{gorilla}\n{snake}\n{lizard}\n{bear}");
        }
    }
}
