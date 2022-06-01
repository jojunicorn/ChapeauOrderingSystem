using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystemModel
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public decimal PaymentAmount { get; set; } 
        public int OrderNumber { get; set; }
        public decimal Tip { get; set; }
        public string CustomerComment { get; set; }


    }

}

