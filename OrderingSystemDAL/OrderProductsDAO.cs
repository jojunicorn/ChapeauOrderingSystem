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
        string query;
        public List<OrderProduct> GetAllOrderProducts()
        {
            query = "SELECT ItemId, OrderNumber, ProductId, Comment, OrderTime, OrderStatus FROM [dbo].[ORDERPRODUCTS]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public OrderProduct GetOrderProduct(int orderNumber, int productNumber)
        {
            query = "SELECT ItemId, OrderNumber, ProductId, Comment, OrderTime, OrderStatus FROM [dbo].[ORDERPRODUCTS] WHERE OrderNumber = @orderNumber AND ProductId = @productId;";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@orderNumber", orderNumber);
            sqlParameters[0] = new SqlParameter("@productId", productNumber);


            OrderProduct order = ReadTable(ExecuteSelectQuery(query, sqlParameters));

            return order;
        }
        public void AddOrderItem(int orderNumber, int productId, string comment, DateTime time, string status)
        {

            query = "INSERT INTO [dbo].[ORDERPRODUCTS] VALUES (@OrderNumber, @ProductId, @Comment, @OrderTime, @Status);";

            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@OrderNumber", orderNumber);
            sqlParameters[1] = new SqlParameter("@ProductId", productId);
            sqlParameters[2] = new SqlParameter("@Comment", comment);
            sqlParameters[3] = new SqlParameter("@OrderTime", time);
            sqlParameters[4] = new SqlParameter("@Status", status);

            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveOrderItem(int productId, int orderId)
        {
            query = "DELETE [dbo].[ORDERPRODUCTS] WHERE OrderNumber=@orderNumber AND ProductId=@productId;";
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@orderNumber", orderId);
            sqlParameters[1] = new SqlParameter("@productId", productId);

            ExecuteEditQuery(query, sqlParameters);
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
                    Status = (string)dr["OrderStatus"],
                };
                orderProducts.Add(orderProduct);
            }
            return orderProducts;
        }
        private OrderProduct ReadTable(DataTable dataTable)
        {

            OrderProduct orderProduct = new OrderProduct();

            foreach (DataRow dr in dataTable.Rows)
            {
                orderProduct.ItemID = (int)dr["ItemId"];
                orderProduct.OrderNumber = (int)dr["OrderNumber"];
                orderProduct.ProductID = (int)dr["ProductId"];
                orderProduct.Comment = (string)dr["Comment"];
                orderProduct.OrderTime = (DateTime)dr["OrderTime"];
                orderProduct.Status = (string)dr["OrderStatus"];


            }
            return orderProduct;
        }
    }
}
