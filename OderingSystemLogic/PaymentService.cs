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
        public void AddPayment(float paymentAmount, float vat, string paymentType, float tip, string customerComment, int orderNumber)
        {
            paymentDao.AddPayment(paymentAmount, vat, paymentType, tip, customerComment, orderNumber);
        }
        public List<Payment>GetPayment()
        {
            return paymentDao.GetPayment();
        }
       public Payment GetPayment(int OrderNumber)
       {
            return paymentDao.GetPayment(OrderNumber);
       }
    }
}
