using System;
using System.Collections.Generic;
using System.Text;
using OrderingSystemModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace OrderingSystemDAL
{

    public class ChefAndBarmanDAO : BaseDAO
    {

        public List<OrderProduct> GetBarOrders()
        {
            string query = "SELECT R.ItemId, R.OrderNumber, R.ProductId, R.Comment, R.OrderTime, R.OrderStatus, P.ProductName FROM [dbo].[ORDERPRODUCTS] AS R JOIN [dbo].[PRODUCT] AS P ON R.ProductId = P.ProductId WHERE ((R.OrderStatus!='prepared') AND (P.MenuCategorie=3)) ORDER BY R.OrderNumber";
            return ReadTables(ExecuteSelectQuery(query));
        }

        public List<OrderProduct> GetKitchenOrders()
        {
            string query = "SELECT R.ItemId, R.OrderNumber, R.ProductId, R.Comment, R.OrderTime, R.OrderStatus, P.ProductName FROM [dbo].[ORDERPRODUCTS] AS R JOIN [dbo].[PRODUCT] AS P ON R.ProductId = P.ProductId WHERE ((R.OrderStatus!='prepared') AND (P.MenuCategorie=1  OR P.MenuCategorie=2)) ORDER BY R.OrderNumber";
            return ReadTables(ExecuteSelectQuery(query));
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

        public void Update(OrderProduct orderProduct)
        {
            string query = $"UPDATE ORDERPRODUCTS SET OrderStatus='{orderProduct.Status}' WHERE ItemID={orderProduct.ItemID}";
            
            //prevent sql injection by checking the corectness of the parameters used in the query
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "@OrderStatus";
            sqlParameters[0].Value = orderProduct.Status;
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
