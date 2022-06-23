using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystemModel
{
    public class Employee
    {
        public int EmployeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePosition { get; set; }
        public string EmployeeUsername { get; set; }
        public string EmployeePassword { get; set; }
        public string Salt { get; set; }

        public override int GetHashCode()
        {
            return EmployeNumber;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Employee))
                return false;
            else
                return GetHashCode() == ((Employee)obj).GetHashCode();
        }


    }
}
