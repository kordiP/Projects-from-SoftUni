using System;
namespace m03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Kordi", "Dunav 40", 19, 91);
            Console.WriteLine(s1.Address);
        }
    }
}
