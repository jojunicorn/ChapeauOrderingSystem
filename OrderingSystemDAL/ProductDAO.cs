using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using OrderingSystemModel;

namespace OrderingSystemDAL
{
    public class ProductDAO : BaseDAO
    {
        public List<Product> GetAllProducts()
        {
            string query = "SELECT ProductId, ProductName, ProductType, Price, VAT, ProductStock, MenuCategory FROM [dbo].[PRODUCT]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Product> ReadTables(DataTable dataTable)
        {

            List<Product> products = new List<Product>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Product product = new Product()
                {
                    ProductID = (int)dr["ProductId"],
                    ProductName = (string)dr["ProductName"],
                    ProductType = (string)dr["ProductType"],
                    Price = (float)dr["Price"],
                    VAT = (float)dr["VAT"],
                    Stock = (int)dr["ProductStock"],
                    ProductCategory = (MenuCategory)dr["MenuCategory"],
                };
                products.Add(product);
            }
            return products;
        }
    }
}
