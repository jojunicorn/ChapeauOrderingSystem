using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystemModel
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public Employee EmployeeNumber { get; set; }
        public Table TableNumber { get; set; }
    }
}
