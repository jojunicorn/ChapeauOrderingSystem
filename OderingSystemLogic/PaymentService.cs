using System;
using System.Collections.Generic;
using System.Text;
using OrderingSystemModel;
using OrderingSystemDAL;

namespace OrderingSystemLogic
{
    public class PaymentService
    {
        private PaymentDAO paymentDao;

        public PaymentService()
        {
            paymentDao = new PaymentDAO();
        }
        public void AddOrderItem(float paymentAmount, string paymentType, float tip, string customerComment, int orderNumber)
        {
            paymentDao.AddOrderItem(paymentAmount, paymentType, tip, customerComment, orderNumber);
        }
        public List<Payment>GetPayment()
        {
            return paymentDao.GetPayment();
        }
       public Payment GetPayment(int OrderNumber)
       {
            return paymentDao.GetPayment(OrderNumber);
       }
       public void AddComment(int OrderNumber, string CustomerComment)
       {
           paymentDao.AddComment(OrderNumber, CustomerComment);
       }
    }
}
