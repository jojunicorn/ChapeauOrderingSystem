using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystemModel
{
    public class Order
    { 
        public int OrderNumber { get; set; }
        public int EmployeeNumber { get; set; } //employee
        public DateTime OrderTime { get; set; }
        //public int TableNumber { get; set; } //table
    }
}
