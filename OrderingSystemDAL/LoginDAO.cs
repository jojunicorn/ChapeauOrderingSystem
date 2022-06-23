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
            string query = $"SELECT [EmployeNumber], [EmployeeName], [EmployeeUsername], [EmployeePassword], [EmployeePosition], [Salt] FROM EMPLOYEE where EmployeeUsername = @Username ";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@Username", username);
            return ReadTable(ExecuteSelectQuery(query, sqlParameter));
        }

        public List<Employee> GetAllUsers()
        {
            string query = $"SELECT [EmployeNumber], [EmployeeName], [EmployeeUsername], [EmployeePassword], [EmployeePosition], [Salt] FROM EMPLOYEE";
            SqlParameter[] sqlParameter = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameter));
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
                employee.EmployeePassword = (string)item["EmployeePassword"];
                employee.Salt = (string)item["Salt"];
            }
            return employee;
        }

        private List<Employee> ReadTables(DataTable dataTable)
        {
            List <Employee> employees = new List <Employee>();

            foreach (DataRow item in dataTable.Rows)
            {

                Employee employee = new Employee()
                {
                    EmployeNumber = (int)item["EmployeNumber"],
                    EmployeeName = (string)item["EmployeeName"],
                    EmployeePosition = (string)item["EmployeePosition"],
                    EmployeeUsername = (string)item["EmployeeUsername"],
                    EmployeePassword = (string)item["EmployeePassword"],
                    Salt = (string)item["Salt"]

                };
                employees.Add(employee);
            }
            return employees;
        }
    }
}
