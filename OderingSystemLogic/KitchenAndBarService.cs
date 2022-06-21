using System;
using System.Collections.Generic;
using System.Text;
using OrderingSystemModel;
using OrderingSystemDAL;

namespace OrderingSystemLogic
{
    public class KitchenAndBarService
    {
        ChefAndBarmanDAO chefAndBarmanDAO;

        public KitchenAndBarService()
        {
            chefAndBarmanDAO = new ChefAndBarmanDAO();
        }

        public List<OrderProduct> GetKitchenOrders()
        {
            return chefAndBarmanDAO.GetKitchenOrders();
        }

        public List<OrderProduct> GetBarOrders()
        {
            return chefAndBarmanDAO.GetBarOrders();
        }

        public void UpdateOrderStatus(OrderProduct orderProduct) 
        {
            chefAndBarmanDAO.Update(orderProduct);
        }
    }
}