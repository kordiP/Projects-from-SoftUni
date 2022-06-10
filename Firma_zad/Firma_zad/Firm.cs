using System.Collections.Generic;
using System;
namespace Firm
{
    internal class Firm
    {
        private string name;
        private List<Employee> employees;
        public string Name { get { return name; } set { name = value; } }
        public List<Employee> Employees { get { return employees; } set { employees = value; } }
        public Firm(string name)
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
            if (employees.Contains(employee))
                RemovalAsk(employee);
            else
            {
                Employee temp = employees.Find(x => x.Id == employee.Id);
                if (temp != null)
                    if (temp.Name == employee.Name && temp.Age == employee.Age)
                        RemovalAsk(temp);
            }
        }
        public void RemovalAsk(Employee employee)
        {
            Console.WriteLine($"Are you sure you want to remove this employee: {employee}?\nY/N?");
            if (Console.ReadLine() == "Y") employees.Remove(employee);
            else Console.WriteLine("Removal canceled.");
        }
        public override string ToString()
        {
            return $"{Name}\n{string.Join("\n", employees)}";
        }
    }
}
