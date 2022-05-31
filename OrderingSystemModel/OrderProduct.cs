using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystemModel
{
    public class OrderProduct
    {
        public int ItemID { set; get; }
        public Order OrderNumber { get; set; }
        public Product ProductID { get; set; }
        //added the field from Product
        public Product ProductDescription { get; set; }
        public string Comment { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
