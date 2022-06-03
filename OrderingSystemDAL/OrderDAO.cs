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
            query = "SELECT OrderNumber, EmployeeNumber FROM [dbo].[ORDER]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Order GetOrder(int orderNumber)
        {
            try
            {
                query = "SELECT OrderNumber, EmployeeNumber FROM [dbo].[ORDER] WHERE OrderNumber = @orderNumber;";

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
        public int CreateNewOrder(Order order)
        {
            query = "INSERT INTO [dbo].[ORDER] VALUES (@employeeNumber, GetDate());";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@employeeNumber", order.EmployeeNumber);
            //sqlParameters[0] = new SqlParameter("@date", order.EmployeeNumber);

            ExecuteEditQuery(query, sqlParameters);

            return GetAllOrders().Count;
        }

        private List<Order> ReadTables(DataTable dataTable)
        {

            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderNumber = (int)dr["OrderNumber"],
                    EmployeeNumber = (int)dr["EmployeeNumber"],
                    //TableNumber = (int)dr["TableNumber"],
                };
                orders.Add(order);
            }
            return orders;
        }
        private Order ReadTable(DataTable dataTable)
        {

            Order order = new Order();

            foreach (DataRow dr in dataTable.Rows)
            {
                order.OrderNumber = (int)dr["OrderNumber"];
                order.EmployeeNumber = (int)dr["EmployeeNumber"];

            }
            return order;
        }
    }
}
