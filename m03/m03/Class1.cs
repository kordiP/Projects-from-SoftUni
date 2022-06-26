using System;

namespace m03
{
    internal class Student
    {
        private string name;
        private int age;
        private double finalGrade;
        //Auto-Implemented Property
        public string Address { get; private set; }
        public string Name
        {
            get
            {
                if (age >= 18) return name;
                else return "Student too young!";
            }
            set
            {
                if (value != "") name = value;
            }
        }
        public int Age
        {
            get
            {
                if (age >= 18) return age;
                else return -1;
            }
            set
            {
                age = value;
            }
        }
        public double FinalGrade
        {
            get 
            {
                return finalGrade; 
            }
            set
            {
                if (value < 65) value = 65;
                else if (value > 100) value = 100;
                finalGrade = value;
            }
        }
        public Student(string name, string address, int age, double finalGrade)
        {
            this.name = name;
            this.Address = address;
            this.age = age;
            this.finalGrade = finalGrade;
        }
        public Student(string name, string address,  int age) : this(name, address, age, 0)
        {

        }
        public void SayHello()
        {
            Console.WriteLine($"Hello from {name}!");
        }
        
    }
}
