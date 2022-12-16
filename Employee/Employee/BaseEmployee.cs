using System;

namespace Employee
{
    public abstract class BaseEmployee
    {
        private string employeeID;
        private string employeeName;
        private string employeeAddress;
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public string EmployeeAddress 
        {
            get { return employeeAddress; } 
            set { employeeAddress= value; }
        }
        protected BaseEmployee(string employeeID, string employeeName, string employeeAddress)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            EmployeeAddress = employeeAddress;
        }

        public virtual string Show()
        {
            return $"Employee ID: {EmployeeID}\nEmployee Name: {EmployeeName}\nEmployee Address: {EmployeeAddress}\n";
        }
        public abstract double CalculateSalary(int workingHours);
        public abstract string GetDepartment();
    }
}
