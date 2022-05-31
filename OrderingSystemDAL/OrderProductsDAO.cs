using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using OrderingSystemModel;

namespace OrderingSystemDAL
{
    public class OrderProductsDAO :BaseDAO
    {
        public List<OrderProduct> GetAllOrderProducts()
        {
            string query = "SELECT ItemId, OrderNumber, ProductId, Comment, OrderTime FROM [dbo].[ORDERPRODUCTS]";
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
                    OrderNumber = (int)dr["OrderNumber"],
                    ProductID = (int)dr["ProductId"],
                    Comment = (string)dr["Comment"],
                    OrderTime = (DateTime)dr["OrderTime"],
                };
                orderProducts.Add(orderProduct);
            }
            return orderProducts;
        }
    }
}
