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
        private List<Product> allProducts;
        private List<Product> lunchProducts;
        private List<Product> dinnerProducts;
        private List<Product> drinkProducts;
        private List<Product> lunchStarters;
        private List<Product> lunchMains;
        private List<Product> lunchDeserts;
        private List<Product> dinnerStarters;
        private List<Product> dinnerEntrements;
        private List<Product> dinnerMains;
        private List<Product> dinnerDeserts;
        private List<Product> drinksSoftDrinks;
        private List<Product> drinksBeers;
        private List<Product> drinksWines;
        private List<Product> drinksSpirits;
        private List<Product> drinksHot;

        public ProductService()
        {
            productDao = new ProductDAO();
            allProducts = new List<Product>();
            lunchProducts = new List<Product>();
            dinnerProducts = new List<Product>();
            drinkProducts = new List<Product>();
            lunchStarters = new List<Product>();
            lunchMains = new List<Product>();
            lunchDeserts = new List<Product>();
            dinnerStarters = new List<Product>();
            dinnerEntrements = new List<Product>();
            dinnerMains = new List<Product>();
            dinnerDeserts = new List<Product>();
            drinksSoftDrinks = new List<Product>();
            drinksBeers = new List<Product>();
            drinksWines = new List<Product>();
            drinksSpirits = new List<Product>();
            drinksHot = new List<Product>();
            GetCategoriesAndTypes();
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
            allProducts = GetAllProducts();

            foreach (Product product in allProducts)
            {
                if (product.ProductCategory == 1)
                {
                    lunchProducts.Add(product);
                }
            }
            return lunchProducts;
        }
        public List<Product> GetDinnerProducts()
        {
            allProducts = GetAllProducts();
            foreach (Product product in allProducts)
            {
                if (product.ProductCategory == 2)
                {
                    dinnerProducts.Add(product);
                }
                else continue;
            }
            return dinnerProducts;
        }
        public List<Product> GetDrinkProducts()
        {
            allProducts = GetAllProducts();

            foreach (Product product in allProducts)
            {
                if (product.ProductCategory == 3)
                {
                    drinkProducts.Add(product);
                }
            }
            return drinkProducts;
        }
        private void GetCategoriesAndTypes()
        {
            foreach (Product product in allProducts)
            {
                if (product.ProductCategory == 1)
                {
                    lunchProducts.Add(product);
                    if (product.ProductType == "starters")
                        lunchStarters.Add(product);
                    else if (product.ProductType == "mains")
                        lunchMains.Add(product);
                    else if (product.ProductType == "deserts")
                        lunchDeserts.Add(product);
                }
                else if (product.ProductCategory == 2)
                {
                    dinnerProducts.Add(product);
                    if (product.ProductType == "starters")
                        dinnerStarters.Add(product);
                    else if (product.ProductType == "entrements")
                        dinnerEntrements.Add(product);
                    else if (product.ProductType == "mains")
                        dinnerMains.Add(product);
                    else if (product.ProductType == "deserts")
                        dinnerDeserts.Add(product);
                }
                else if (product.ProductCategory == 3)
                {
                    drinkProducts.Add(product);
                    if (product.ProductType == "soft drinks")
                        drinksSoftDrinks.Add(product);
                    else if (product.ProductType == "beers")
                        drinksBeers.Add(product);
                    else if (product.ProductType == "wines")
                        drinksWines.Add(product);
                    else if (product.ProductType == "spirits")
                        drinksSpirits.Add(product);
                    else if (product.ProductType == "coffee/tea")
                        drinksHot.Add(product);
                }
            }
        }

        public List<Product> GetProducts()
        {
            return allProducts;
        }
        public List<Product> GetLunchStarters()
        {
            return lunchStarters;
        }
        public List<Product> GetLunchMains()
        {
            return lunchMains;
        }
        public List<Product> GetLunchDeserts()
        {
            return lunchDeserts;
        }
        public List<Product> GetDinnerStarters()
        {
            return dinnerStarters;
        }
        public List<Product> GetDinnerEntrements()
        {
            return dinnerEntrements;
        }
        public List<Product> GetDinnerMains()
        {
            return dinnerMains;
        }
        public List<Product> GetDinnerDeserts()
        {
            return dinnerDeserts;
        }
        public List<Product> GetDrinkSoftDrinks()
        {
            return drinksSoftDrinks;
        }
        public List<Product> GetDrinksBeers()
        {
            return drinksBeers;
        }
        public List<Product> GetDrinksWines()
        {
            return drinksWines;
        }
        public List<Product> GetDrinksSpirits()
        {
            return drinksSpirits;
        }
        public List<Product> GetDrinksHot()
        {
            return drinksHot;
        }

    }
}
