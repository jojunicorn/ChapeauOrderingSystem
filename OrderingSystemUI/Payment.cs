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
    public partial class Payment : Form
    {
        TableService service = new TableService();
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            List<Table> tables = service.GetTables();
            foreach(Table table in tables)
            {
                ListViewItem item = new ListViewItem();
                item.Text = table.TableNumber.ToString();
                listView1.Items.Add(item);
            }
        }
    }
}
