using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystemModel
{
    public class OrderProduct
    {
        public int ItemID { set; get; }

        public int OrderNumber { get; set; } // convert to order
        public int ProductID { get; set; } //convert to order
        public string Comment { get; set; }
        public DateTime OrderTime { get; set; }
        public int Count { get; set; }
        public string Status { get; set; }
    }
}
