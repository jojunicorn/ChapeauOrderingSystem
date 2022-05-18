using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OrderingSystemModel;
using OrderingSystemLogic;

namespace OrderingSystemUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();            
            TableService tableService = new TableService();
            List<Table> tables = tableService.GetTables();
            foreach (Table table in tables)
            {
                ListViewItem item = new ListViewItem();
                item.Text = table.tableNumber.ToString();
                item.SubItems.Add(table.tableStatus);

                listView1.Items.Add(item);
            }
        }

    }
}
