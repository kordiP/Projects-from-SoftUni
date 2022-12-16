using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    internal class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;
        private string employeeDepartament;
        public string EmployeePosition 
        {
            get { return employeePosition; }
            set { employeePosition = value; } 
        }
        public string EmployeeDepartament 
        {
            get { return employeeDepartament; }
            set { employeeDepartament = value; }
        }
        public FullTimeEmployee(string id, string name, string address, string position, string departament) : base(id, name, address)
        {
            this.EmployeePosition= position;
            this.EmployeeDepartament= departament;
        }

        public override string Show()
        {
            return base.Show() + $"Employee Position: {EmployeePosition}\nEmployee Departament: {EmployeeDepartament}";
        }
        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.80;
        }

        public override string GetDepartment()
        {
            return EmployeeDepartament;
        }
    }
}
