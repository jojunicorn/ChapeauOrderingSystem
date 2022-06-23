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

        public void UpdateTableWithCurrentOrder(Table table, int orderNumber)
        {
            try
            {
                tabledao.UpdateTableWithCurrentOrder(table, orderNumber);
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong while updating the table.");
            }
        }
        public Table GetTable(int tableNumber)
        {
            try
            {
                return tabledao.GetTable(tableNumber);
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong while loading the table.");
            }
        }

        public void ChangeTableStatus(int tableNumber, string tableStatus)
        {
            try
            {
                tabledao.ChangeTableStatus(tableNumber, tableStatus);
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong while changing the status.");
            }
        }
    }
}
