using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystemModel
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductType { get; set; }
        public float Price { get; set; }
        public float VAT { get; set; }
        public int Stock { get; set; }
        public MenuCategory ProductCategory { get; set; }
    }
}
