using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using OrderingSystemModel;

namespace OrderingSystemDAL
{
    public class TableDAO : BaseDAO
    {
      
        public Table GetTable(int tableNumber)
        {
            string query = "SELECT TableNumber, TableStatus, OrderNumber FROM [dbo].[TABLE] WHERE TableNumber = @TableNumber";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TableNumber", tableNumber);
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateTableWithCurrentOrder(Table table,int orderNumber)
        {
            string query = ("UPDATE [dbo].[TABLE] SET OrderNumber = @orderNumber" + " WHERE TableNumber = @tableNumber");
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@orderNumber", orderNumber);
            sqlParameters[1] = new SqlParameter("@tableNumber", table.TableNumber);

            ExecuteEditQuery(query, sqlParameters);
        }

        public void ChangeTableStatus(int tableNumber, string tableStatus)
        {
            string query = "UPDATE [dbo].[TABLE] SET TableStatus = @TableStatus WHERE TableNumber = @TableNumber";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@TableNumber", tableNumber);
            sqlParameters[1] = new SqlParameter("@TableStatus", tableStatus);
            ExecuteEditQuery(query, sqlParameters);
        }

        private Table ReadTable(DataTable dataTable)
        {

            Table table = new Table();

            foreach (DataRow dr in dataTable.Rows)
            {
                table.TableNumber = (int)dr["TableNumber"];
                table.TableStatus = (string)dr["TableStatus"];
                table.CurrentOrder = (int)dr["OrderNumber"];

            }
            return table;
        }
    }
    
}
