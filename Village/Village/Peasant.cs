using System;

namespace Village
{
    class Peasant : Person
    {
        private int productivity;
        public int Productivity
        {
            get { return productivity; }
            set 
            {
                if (value > 0) productivity = value;
                else throw new ArgumentException("Productivity cannot be less or equal to 0!");
            }
        }
        public override int Age
        {
            get { return base.Age; }
            set
            {
                if (value <= 110) base.Age = value;
                else throw new ArgumentException("Age cannot be greater than 110!");
            }
        }
        public Peasant(string name, int age, int productivity) : base(name, age)
        {
            Name = name;
            Age = age;
            Productivity = productivity;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nProductivity: {Productivity}\n";
        }
    }
}