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
            string query = $"SELECT [EmployeeUsername], [Password], [EmployeePosition] FROM [EMPLOYEE] where EmployeeUsername = @Username ";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@Username", username);
            return ReadTable(ExecuteSelectQuery(query, sqlParameter));
        }


        private Employee ReadTable(DataTable dataTable)
        {
            Employee employee = new Employee();

            foreach (DataRow item in dataTable.Rows)
            {
                employee.EmployeeNumber = (int)item["EmployeeNumber"];
                employee.EmployeeName = (string)item["EmployeeName"];
                employee.EmployeePosition = (string)item["EmployeePosition"];
                employee.EmployeeUsername = (string)item["EmployeeUsername"];
                employee.EmployeePassword = (string)item["EmployeePassword"];

            }
            return employee;
        }
    }
}
