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
        public OrderProduct GetOrderProduct(int orderNumber, int productNumber)
        {
            return orderProductDao.GetOrderProduct(orderNumber, productNumber);
        }
        public void AddComment(int itemId, string comment)
        {
            orderProductDao.AddComment(itemId, comment);
        }
        public void RemoveOrderItem(int productId, int orderId)
        {
            orderProductDao.RemoveOrderItem(productId, orderId);
        }
        public void RemoveOneOrderItem(int itemId)
        {
            orderProductDao.RemoveOneOrderItem(itemId);
        }
        public void AddOrderItem(int orderNumber, int productId, string comment, int category)
        {
            orderProductDao.AddOrderItem(orderNumber, productId, comment,category);
        }
        public OrderProductService()
        {
            orderProductDao = new OrderProductsDAO();
        }

        public List<OrderProduct> GetAllOrderProducts()
        {
            return orderProductDao.GetAllOrderProducts();

        }

        public List<OrderProduct> GetOrderProductsDrink(int orderNumber)
        {
            return orderProductDao.GetOrderProductsDrink(orderNumber);

        }

        public List<OrderProduct> GetOrderProductsFood(int orderNumber)
        {
            return orderProductDao.GetOrderProductsFood(orderNumber);

        }
    }
}
