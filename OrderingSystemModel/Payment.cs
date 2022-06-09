using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystemModel
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public float PaymentAmount { get; set; } 
        public string PaymentType { get; set; }
        public int OrderNumber { get; set; }
        public float Tip { get; set; }
        public string CustomerComment { get; set; }


    }

}

