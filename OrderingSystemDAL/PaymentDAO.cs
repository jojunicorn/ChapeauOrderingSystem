using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using OrderingSystemModel;
namespace OrderingSystemDAL
{
    public class PaymentDAO : BaseDAO
    {
        string query = "";

        public List<Payment> GetPayment()
        {
            query = "SELECT PaymentID, PaymentAmount, PaymentVAT, PaymentType, OrderNumber, Tip, CustomerComment FROM [dbo].[PAYMENT]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddPayment(float paymentAmount, float vat, string paymentType, float tip, string customerComment, int orderNumber)
        {

            query = "INSERT INTO [dbo].[PAYMENT] VALUES (@PaymentAmount, @PaymentVAT, @PaymentType, @Tip, @CustomerComment, @OrderNumber);";

            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@PaymentAmount", paymentAmount);
            sqlParameters[1] = new SqlParameter("@PaymentVAT", vat);
            sqlParameters[2] = new SqlParameter("@PaymentType", paymentType);
            sqlParameters[3] = new SqlParameter("@Tip", tip);
            sqlParameters[4] = new SqlParameter("@CustomerComment", customerComment);
            sqlParameters[5] = new SqlParameter("@OrderNumber", orderNumber);

            ExecuteEditQuery(query, sqlParameters);
        }
        public Payment GetPayment(int orderNumber)
        {
            try
            {
                query = "SELECT PaymentID, PaymentAmount,PaymentType, OrderNumber, Tip, CustomerComment FROM [dbo].[PAYMENT] WHERE OrderNumber = @orderNumber;";

                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@orderNumber", orderNumber);

                Payment payment = ReadTable(ExecuteSelectQuery(query, sqlParameters));

                return payment;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<Payment> ReadTables(DataTable dataTable)
        {
            List<Payment> payments = new List<Payment>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Payment payment = new Payment()
                {
                    PaymentID = (int)dr["PaymentID"],
                    PaymentAmount = (float)dr["PaymentAmount"],
                    PaymentVat = (float)dr["PaymentVAT"],
                    PaymentType = (string)dr["PaymentType"],
                    OrderNumber = (int)dr["OrderNumber"],
                    Tip = (float)dr["Tip"],
                    CustomerComment= (string)dr["CustomerComment"],

                };
                payments.Add(payment);
            }
            return payments;
        }
        private Payment ReadTable(DataTable dataTable)
        {
            DataRow dataRow = dataTable.Rows[0];

            Payment payment = new Payment()
            {
                PaymentID = (int)dataRow["PaymentID"],
                PaymentAmount = (float)dataRow["PaymentAmount"],
                PaymentVat = (float)dataRow["PaymentVAT"],
                PaymentType = (string)dataRow["PaymentType"],
                OrderNumber = (int)dataRow["OrderNumber"],
                Tip = (float)dataRow["Tip"],
                CustomerComment = (string)dataRow["CustomerComment"],
            };

            return payment;
        }
       

    }
}
