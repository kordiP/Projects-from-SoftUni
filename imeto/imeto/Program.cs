using System;

namespace imeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("На колко години си?");
            string godini = Console.ReadLine();
            Console.Write("Как се казваш?");
            string name = Console.ReadLine();           
            Console.WriteLine("Вие сте на {0} години и се казвате {1}.",godini,name);
        }
    }
}
