using System;
using System.Collections.Generic;
using System.Text;
using OrderingSystemModel;
using System.Data;
using System.Data.SqlClient;

namespace OrderingSystemDAL
{
    public class ChefDAO : BaseDAO
    {
        public List<OrderProduct> GetAllOrders()
        {
            string query = "SELECT R.OrderNumber, R.ProductId, R.OrderTime, P.ProductDescription FROM [dbo].[ORDERPRODUCTS] AS R JOIN [dbo].[PRODUCT] AS P ON R.ProductId = P.ProductId ORDER BY R.OrderNumber";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderProduct> ReadTables(DataTable dataTable)
        {
            List<OrderProduct> orderProducts = new List<OrderProduct>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderProduct orderProduct = new OrderProduct()
                {
                    ItemID = (int)dr["ItemId"],
                    OrderNumber = (Order)dr["OrderNumber"],
                    ProductID = (Product)dr["TableNumber"],
                    Comment = (string)dr["Comment"],
                    OrderTime = (DateTime)dr["OrderTime"],
                };
                orderProducts.Add(orderProduct);
            }

            return orderProducts;
        }
    }
}
