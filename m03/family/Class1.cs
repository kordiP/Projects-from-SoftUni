using System;
using System.Collections.Generic;
using System.Linq;

namespace family
{
    internal class Family
    {
        private SortedDictionary<string, int> members = new SortedDictionary<string, int>();
        public string Name { get; set; }
        public Family()
        {

        }
        public void AddMember(Person member)
        {
            members.Add(member.Name, member.Age);
        }
        public void Print()
        {
            Console.WriteLine("Фамилия: " + Name);
            foreach (var member in members)
                Console.WriteLine(member.Key + " " + member.Value);
        }
        public int GetAverageAge()
        {
            
                int avg = members.Sum(x => x.Value) / members.Count;
                return avg;          
        }
        public int Average 
        {
            get { return members.Sum(x => x.Value) / members.Count; } 
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
    }
}
