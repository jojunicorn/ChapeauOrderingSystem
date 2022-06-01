using System;
using System.Collections.Generic;
using System.Text;
using OrderingSystemDAL;
using OrderingSystemModel;

namespace OrderingSystemLogic
{
    public class OrderProductService
    {
        private OrderProductsDAO orderProductDao;

        public OrderProductService()
        {
            orderProductDao = new OrderProductsDAO();
        }

        public List<OrderProduct> GetAllOrderProducts()
        {
            return orderProductDao.GetAllOrderProducts();

        }
        
    }
}
