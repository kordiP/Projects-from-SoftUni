using System;
using System.Collections.Generic;
namespace Company
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Company> companies = new Dictionary<string, Company>();
            Dictionary<string, Employee> employees = new Dictionary<string, Employee>();
            Employee e1 = new Employee(69, "Kordi", 17);
            Employee e2 = new Employee(101, "Val", 18);
            Company c1 = new Company("Kompaniq nomer 1");
            c1.Hire(e1);
            c1.Hire(e2);
            Console.WriteLine(c1);
            Employee firedEmployee = new Employee(101, "Val", 18);
            c1.Fire(firedEmployee);
            Console.WriteLine(c1);
        }
    }
    class Employee
    {
        private int id;
        private string name;
        private int age;
        public int ID
        {
            get { return id; }
            set { id = value; }
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
        public Employee(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $" {ID} {Name} {Age}\n";
        }
    }
    class Company
    {
        private string name;
        private List<Employee> employees;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        public Company(string name)
        {
            Name = name;
            employees = new List<Employee>();
        }
        public void Hire(Employee employee)
        {
            employees.Add(employee);
        }
        public void Fire(Employee employee)
        {
            Employee temp = employees.Find(x => x.ID == employee.ID);
            employees.Remove(temp);
        }
        public override string ToString()
        {
            return $"{Name} \n {String.Join(" ", Employees)}";
        }
    }
}
