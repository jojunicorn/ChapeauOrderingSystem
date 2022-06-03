using System;
using System.Collections.Generic;
using System.Text;
using OrderingSystemModel;
using OrderingSystemDAL;

namespace OrderingSystemLogic
{
    public class BarViewService
    {
        BarmanDAO barmanDAO;

        public BarViewService()
        {
            barmanDAO = new BarmanDAO();
        }

        public List<OrderProduct> GetOrders()
        {
            return barmanDAO.GetAllOrders();
        }
    }
}
