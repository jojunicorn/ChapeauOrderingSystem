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
        string query = "";
        public List<Product> GetAllProducts()
        {
            query = "SELECT ProductId, ProductName, ProductType, Price, VAT, ProductStock, MenuCategorie FROM [dbo].[PRODUCT]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Product GetProduct(int productId)
        {
            try
            {
                query = "SELECT ProductId, ProductName, ProductType, Price, VAT, ProductStock, MenuCategorie FROM [dbo].[PRODUCT] WHERE ProductId = @productId;";

                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@productId", productId);

                Product product = ReadTable(ExecuteSelectQuery(query, sqlParameters));

                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditStock(int productId, int newStock)
        {
            query = "UPDATE [dbo].[PRODUCT] SET ProductStock=@productStock WHERE ProductId=@productId;";
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@productId", productId);
            sqlParameters[1] = new SqlParameter("@productStock", 50);


            ExecuteEditQuery(query, sqlParameters);
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
                    ProductCategory = (int)dr["MenuCategorie"],
                };
                products.Add(product);
            }
            return products;
        }
        private Product ReadTable(DataTable dataTable)
        {

            DataRow dataRow = dataTable.Rows[0];

            Product product = new Product()
            {
                ProductID = (int)dataRow["ProductId"],
                ProductName = (string)dataRow["ProductName"],
                ProductType = (string)dataRow["ProductType"],
                Price = (float)dataRow["Price"],
                VAT = (float)dataRow["VAT"],
                Stock = (int)dataRow["ProductStock"],
                ProductCategory = (int)dataRow["MenuCategorie"],
            };

            return product;
        }
    }
}
