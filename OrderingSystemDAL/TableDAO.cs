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
        public List<Table> GetAllTables()
        {
            string query = "SELECT TableNumber, TableStatus FROM [TABLES]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            //creating student list

            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    tableNumber = (int)dr["TableNumber"],
                    tableStatus = (string)dr["TableStatus"],
                };
                tables.Add(table);
            }
            return tables;
        }
    }
}
