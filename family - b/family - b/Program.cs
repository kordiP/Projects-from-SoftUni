using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._05.___present
{
    class Person
    {
        private string name;
        private int age;
        public string Name { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }

    class Family
    {
        public string Name { get; set; }
        public List<Person> family = new List<Person>();
        public void AddMember(Person person)
        {
            family.Add(person);
        }

        public override string ToString()
        {
            return $"Фамилия: {Name}\n{String.Join(",\n", family)}";
        }

        public void Print()
        {
            foreach (Person person in family.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
            //Console.WriteLine(String.Join(",\n", family));
        }

        public void Print2()
        {
            Console.WriteLine(string.Join(' ', family.ToString()));
        }

        public void Sort()
        {
            family.OrderBy(x => x.Name);
        }
    }

    class Program
    {
        static void Main()
        {
            int amount = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < amount; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person person = new Person();
                person.Name = input[0];
                person.Age = int.Parse(input[1]);
                family.AddMember(person);
            }
            //family.Sort();
            Console.WriteLine(family.ToString());
            //family.Print2();
        }
    }
}