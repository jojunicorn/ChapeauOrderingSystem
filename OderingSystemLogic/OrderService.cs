using System;
using System.Collections.Generic;
using System.Text;
using OrderingSystemModel;
using OrderingSystemDAL;

namespace OrderingSystemLogic
{
    public class OrderService
    {
        private OrderDAO orderDao;

        public OrderService()
        {
            orderDao = new OrderDAO();
        }

        public List<Order> GetOrders()
        {
            return orderDao.GetAllOrders();
        }
        public Order GetOrder(int orderNumber)
        {
            return orderDao.GetOrder(orderNumber);
        }
    }
}
