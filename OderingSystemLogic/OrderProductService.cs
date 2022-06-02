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

        public void RemoveOrderItem(int productId, int orderId)
        {
            orderProductDao.RemoveOrderItem(productId, orderId);
        }
        public void AddOrderItem(int orderNumber, int productId, string comment, DateTime time, string status)
        {
            orderProductDao.AddOrderItem(orderNumber, productId, comment, time, status);
        }
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
