using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystemModel
{
    public class Employee
    {
        public int EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePosition { get; set; }
        public string EmployeeUsername { get; set; }
        public string EmployeePassword { get; set; }

        public Employee(int employeeNumber, string employeeName, string employeePosition, string employeeUsername, string employeePassword)
        {
            EmployeeNumber = employeeNumber;
            EmployeeName = employeeName;
            EmployeePosition = employeePosition;
            EmployeeUsername = employeeUsername;
            EmployeePassword = employeePassword;
        }

        public Employee()
        {

        }
    }
}
