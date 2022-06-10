using System;
using System.Collections.Generic;

namespace Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Firm> firms = new Dictionary<string, Firm>();
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
            Firm firm1 = new Firm("GoshkoLend");
            Firm firm2 = new Firm("GanqLend");
            Employee employee1 = new Employee(1, "Emil", 65);
            Employee employee2 = new Employee(17, "Stefan", 25);
            firms[firm1.Name] = firm1;
            firms[firm2.Name] = firm2;
            employees[employee1.Id] = employee1;
            employees[employee2.Id] = employee2;
            firm1.Hire(employee1);
            firm1.Hire(employee2);
            Console.WriteLine(firm1);
            Employee FiredEmployee = new Employee(1, "Emil", 65);
            firm1.Fire(FiredEmployee);
            Console.WriteLine(firm1);
        }
    }
}
