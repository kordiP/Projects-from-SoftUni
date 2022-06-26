using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Statistics
{
    internal class PeopleOver30
    {
        private SortedDictionary<string, int> members = new SortedDictionary<string, int>();
        public PeopleOver30()
        {

        }
        public void AddMember(Person member)
        {
            if (member.Age > 30) 
            {
                members.Add(member.Name, member.Age);
            }
        }
        public void Print()
        {
            foreach (var member in members)
                Console.WriteLine(member.Key + " " + member.Value);
        }
    }
    internal class Person
    {
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //public void PrintMem()
        //{
        //    Console.WriteLine(name + " " + age);
        //}

    }
}
