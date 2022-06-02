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
        public void UpdateTableWithCurrentOrder(Table table, int orderNumber)
        {
            tabledao.UpdateTableWithCurrentOrder(table, orderNumber);
        }
        public Table GetTable(int tableNumber)
        {
            return tabledao.GetTable(tableNumber);
        }
    }
}
