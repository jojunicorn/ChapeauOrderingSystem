using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using OrderingSystemModel;
namespace OrderingSystemDAL
{
    public class OrderDAO :BaseDAO
    {
        public List<Order> GetAllOrders()
        {
            string query = "SELECT OrderNumber, EmployeNumber, TableNumber FROM [dbo].[ORDER]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTables(DataTable dataTable)
        {

            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderNumber = (int)dr["OrderNumber"],
                    EmployeeNumber = (Employee)dr["EmployeNumber"],
                    TableNumber = (Table)dr["TableNumber"],
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
