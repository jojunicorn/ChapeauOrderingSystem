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
            query = "SELECT ItemId, OrderNumber, ProductId, Comment, OrderTime, OrderStatus, ProductCategory FROM [dbo].[ORDERPRODUCTS]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public OrderProduct GetOrderProduct(int orderNumber, int productNumber)
        {
            query = "SELECT ItemId, OrderNumber, ProductId, Comment, OrderTime, OrderStatus, ProductCategory FROM [dbo].[ORDERPRODUCTS] WHERE OrderNumber = @orderNumber AND ProductId = @productId;";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@orderNumber", orderNumber);
            sqlParameters[1] = new SqlParameter("@productId", productNumber);


            OrderProduct order = ReadTable(ExecuteSelectQuery(query, sqlParameters));

            return order;
        }

        public void AddComment(int itemId, string comment)
        {
            query = "UPDATE [dbo].[ORDERPRODUCTS] SET Comment=@comment WHERE ItemId=@itemId;";
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@comment", comment);
            sqlParameters[1] = new SqlParameter("@itemId", itemId);


            ExecuteEditQuery(query, sqlParameters);
        }
        public void AddOrderItem(int orderNumber, int productId, string comment, DateTime time, string status, int category)
        {

            query = "INSERT INTO [dbo].[ORDERPRODUCTS] VALUES (@OrderNumber, @ProductId, @Comment, @OrderTime, @Status ,@ProductCategory);";

            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@OrderNumber", orderNumber);
            sqlParameters[1] = new SqlParameter("@ProductId", productId);
            sqlParameters[2] = new SqlParameter("@Comment", comment);
            sqlParameters[3] = new SqlParameter("@OrderTime", time);
            sqlParameters[4] = new SqlParameter("@Status", status);
            sqlParameters[5] = new SqlParameter("@ProductCategory", category);


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
        public void RemoveOneOrderItem(int itemId)
        {
            query = "DELETE [dbo].[ORDERPRODUCTS] WHERE ItemId=@itemId;";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@itemId", itemId);

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
                    ProductCategory = (int)dr["ProductCategory"]
                };
                orderProducts.Add(orderProduct);
            }
            return orderProducts;
        }
        private OrderProduct ReadTable(DataTable dataTable)
        {

            DataRow dataRow = dataTable.Rows[0];

            OrderProduct product = new OrderProduct()
            {
                ItemID = (int)dataRow["ItemId"],
                OrderNumber = (int)dataRow["OrderNumber"],
                ProductID = (int)dataRow["ProductId"],
                Comment = (string)dataRow["Comment"],
                OrderTime = (DateTime)dataRow["OrderTime"],
                Status = (string)dataRow["OrderStatus"],
                ProductCategory = (int)dataRow["ProductCategory"]
            };

            return product;

        }
    }
}
