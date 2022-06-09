using System;
using System.Collections.Generic;
using System.Text;
using OrderingSystemModel;
using OrderingSystemDAL;

namespace OrderingSystemLogic
{
    public class KitchenViewService
    {
        ChefDAO chefDAO;

        public KitchenViewService()
        {
            chefDAO = new ChefDAO();
        }


        public List<OrderProduct> GetOrders()
        {
            return chefDAO.GetAllOrders();
        }


        public void UpdateOrderStatus(OrderProduct orderProduct) 
        {
            chefDAO.Update(orderProduct);
        }
    }
}