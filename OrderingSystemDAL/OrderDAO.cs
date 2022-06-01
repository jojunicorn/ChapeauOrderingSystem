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
        string query = "";
        public List<Order> GetAllOrders()
        {
            query = "SELECT OrderNumber, EmployeNumber, TableNumber FROM [dbo].[ORDER]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Order GetOrder(int orderNumber)
        {
            try
            {
                query = "SELECT OrderNumber, EmployeNumber, TableNumber FROM [dbo].[ORDER] WHERE OrderNumber = @orderNumber;";

                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@orderNumber", orderNumber);

                Order order = ReadTable(ExecuteSelectQuery(query, sqlParameters));

                return order;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<Order> ReadTables(DataTable dataTable)
        {

            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderNumber = (int)dr["OrderNumber"],
                    EmployeeNumber = (int)dr["EmployeNumber"],
                    TableNumber = (int)dr["TableNumber"],
                };
                orders.Add(order);
            }
            return orders;
        }
        private Order ReadTable(DataTable dataTable)
        {

            DataRow dataRow = dataTable.Rows[0];

            Order order = new Order()
            {
                OrderNumber = (int)dataRow["OrderNumber"],
                EmployeeNumber = (int)dataRow["EmployeNumber"],
                TableNumber = (int)dataRow["TableNumber"],
            };

            return order;
        }
    }
}
