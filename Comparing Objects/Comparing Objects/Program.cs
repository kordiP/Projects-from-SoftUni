using System;
using System.Collections.Generic;

namespace Comparing_Objects
{
    class Person
    {
        private int id;
        private string name;
        private int age;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

    }
    internal class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            Person p1 = new Person(2, "Todor", 19);
            Person p2 = new Person(1, "Gosho", 19);
            people.Add(p1);
            people.Add(p2);
            Person pTemp = people.Find(x => x.Id == 1);
            Console.WriteLine(pTemp.Name);
            Console.WriteLine(p1.Id == p2.Id);
            
        }
    }
}
