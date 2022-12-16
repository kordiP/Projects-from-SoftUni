using System;

namespace Employee
{
    internal class Program
    {
        static void Main()
        {
            ContractEmployee contractEmployee = new ContractEmployee("1", "Valio", "Bin 12", "Janitor", "Janitor");
            Console.WriteLine(contractEmployee.Show());
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("2", "Kordi", "Mansion 6", "SQL/C#", "Software");
            Console.WriteLine(fullTimeEmployee.Show());
        }
    }
}
