using System;
using System.Collections.Generic;
using System.Text;
using OrderingSystemDAL;
using OrderingSystemModel;

namespace OrderingSystemLogic
{
    public class ProductService
    {
        private ProductDAO productDao;


        public ProductService()
        {
            productDao = new ProductDAO();
        }

        public void EditStock(int productId, int newStock)
        {
            productDao.EditStock(productId, newStock);
        }
        public List<Product> GetAllProducts()
        {
           return productDao.GetAllProducts();
        }
        public Product GetProduct(int productId)
        {
            return productDao.GetProduct(productId);
        }
        public List<Product> GetLunchProducts()
        {
            return productDao.GetLunchProducts();
        }
        public List<Product> GetDinnerProducts()
        {
            return productDao.GetDinnerProducts();
        }
        public List<Product> GetDrinkProducts()
        {
            return productDao.GetDrinkProducts();
        }

        

    }
}
