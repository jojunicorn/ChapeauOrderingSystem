﻿using System;
using System.Collections.Generic;
using System.Text;
using OrderingSystemModel;
using System.Data;
using System.Data.SqlClient;

namespace OrderingSystemDAL
{
    public class BarmanDAO : BaseDAO
    {
        public List<OrderProduct> GetAllOrders()
        {
            string query = "SELECT R.ItemId, R.OrderNumber, R.ProductId, R.Comment, R.OrderTime, R.OrderStatus, P.ProductName FROM [dbo].[ORDERPRODUCTS] AS R JOIN [dbo].[PRODUCT] AS P ON R.ProductId = P.ProductId WHERE P.MenuCategorie=3 ORDER BY R.OrderNumber";
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
                    ProductID = (int)dr["ProductID"],
                    ProductName = (string)dr["ProductName"],
                    Comment = (string)dr["Comment"],
                    OrderTime = (DateTime)dr["OrderTime"],
                    Count = 0,
                    Status = (string)dr["OrderStatus"]
                };
                orderProducts.Add(orderProduct);
            }

            return orderProducts;
        }

    }
}
