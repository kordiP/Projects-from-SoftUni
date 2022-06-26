using System;

namespace People_Statistics
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PeopleOver30 PeopleOver30 = new PeopleOver30();   // convert to people over 30.
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name1 = input[0]; int age1 = int.Parse(input[1]);
                Person p1 = new Person(name1, age1);
                PeopleOver30.AddMember(p1);
            }
            PeopleOver30.Print();
        }
    }
}
