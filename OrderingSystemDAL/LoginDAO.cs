using OrderingSystemModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace OrderingSystemDAL
{
    public class LoginDAO : BaseDAO
    {
        public Employee GetUser(string username)
        {
            string query = $"SELECT [EmployeNumber], [EmployeeName], [EmployeeUsername], [EmployeePassword], [EmployeePosition] FROM EMPLOYEE where EmployeeUsername = @Username ";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@Username", username);
            return ReadTable(ExecuteSelectQuery(query, sqlParameter));
        }


        private Employee ReadTable(DataTable dataTable)
        {
            Employee employee = new Employee();

            foreach (DataRow item in dataTable.Rows)
            {
                employee.EmployeNumber = (int)item["EmployeNumber"];
                employee.EmployeeName = (string)item["EmployeeName"];
                employee.EmployeePosition = (string)item["EmployeePosition"];
                employee.EmployeeUsername = (string)item["EmployeeUsername"];
                employee.EmployeePassword = (int)item["EmployeePassword"];

            }
            return employee;
        }
    }
}
