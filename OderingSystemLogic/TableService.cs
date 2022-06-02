using System;
using OrderingSystemModel;
using OrderingSystemDAL;
using System.Collections.Generic;

namespace OrderingSystemLogic
{
    public class TableService
    {
        private TableDAO tabledao;

        public TableService()
        {
            tabledao = new TableDAO();
        }

        public List<Table> GetTables()
        {
            return tabledao.GetAllTables();

        }

        public Table GetTable(int tableNumber)
        {
            return tabledao.GetTable(tableNumber);
        }
    }
}
