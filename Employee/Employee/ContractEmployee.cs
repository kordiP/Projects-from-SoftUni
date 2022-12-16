using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    internal class ContractEmployee : BaseEmployee
    {
        private string employeeTask;
        private string employeeDepartament;
        public string EmployeeTask
        {
            get { return employeeTask; }
            set { employeeTask = value; }
        }
        public string EmployeeDepartament
        {
            get { return employeeDepartament; }
            set { employeeDepartament = value; }
        }
        public ContractEmployee(string id, string name, string address, string position, string departament) : base(id, name, address)
        {
            this.EmployeeTask = position;
            this.EmployeeDepartament = departament;
        }

        public override string Show()
        {
            return base.Show() + $"Employee Task: {EmployeeTask}\n";
        }
        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 20;
        }

        public override string GetDepartment()
        {
            return EmployeeDepartament;
        }
    }
}
