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
            query = "SELECT PaymentID, PaymentAmount, OrderNumber, Tip, CustomerComment FROM [dbo].[PAYMENT]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Payment GetPayment(int orderNumber)
        {
            try
            {
                query = "SELECT PaymentID, PaymentAmount, OrderNumber, Tip, CustomerComment FROM [dbo].[PAYMENT] WHERE OrderNumber = @orderNumber;";

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
                    PaymentAmount = (decimal)dr["PaymentAmount"],
                    OrderNumber = (int)dr["OrderNumber"],
                    Tip = (decimal)dr["Tip"],
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
                PaymentAmount = (decimal)dataRow["PaymentAmount"],
                OrderNumber = (int)dataRow["OrderNumber"],
                Tip = (decimal)dataRow["Tip"],
                CustomerComment = (string)dataRow["CustomerComment"],
            };

            return payment;
        }
    }
}
