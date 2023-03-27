using System;

namespace Village
{
    abstract class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set 
            {
                if (value.Length >= 3 && value.Length <= 30) name = value;
                else throw new ArgumentException("Name should be between 3 and 30 characters!");
            }
        }
        private int age;
        public virtual int Age
        {
            get { return age; }
            set
            {
                if (value >= 0) age = value;
                else throw new ArgumentException("Age should be 0 or positive!");
            }
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}";
        }
    }
}