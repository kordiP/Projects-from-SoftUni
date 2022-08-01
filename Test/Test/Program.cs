using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "Pleven", s1;
            //Console.WriteLine(s);
            //s1 = s.Substring(1, s.Lenght-1);
            //Console.WriteLine(s1);
            string s = "Hello, Marua,\n" +
            "izpratih ti pratka na adres:\n" +
            "5800 Pleven, ulitsa\"I.Iwanow\"12\n" +
            "za Marua Georgieva Markova";
            string s1;
            Console.WriteLine("Predi:");
            Console.WriteLine(s);
            s1 = s.Replace("Marua","Maria");
            Console.WriteLine("Sled:");
            Console.WriteLine(s1);
            Console.ReadLine();
        }
    }
}
