using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OrderingSystemModel;
using OrderingSystemDAL;
using OrderingSystemLogic;

namespace OrderingSystemUI
{
    public partial class BarmanUI : Form
    {
        BarViewService barViewService = new BarViewService();
        List<OrderProduct> orderProducts;

        public BarmanUI()
        {
            InitializeComponent();
        }

        private void BarmanUI_Load(object sender, EventArgs e)
        {
            DisplayOrders();
        }

        private void DisplayOrders()
        {
            orderProducts = barViewService.GetOrders();
            // clear the listview before filling it again
            listViewOrdersBarView.Clear();

            //set the listView to details view

            listViewOrdersBarView.View = View.Details;


            // Select the item and subitems when selection is made.
            listViewOrdersBarView.FullRowSelect = true;

            // Display grid lines.
            listViewOrdersBarView.GridLines = true;


            //created the columns for the attributes of the order product

            listViewOrdersBarView.Columns.Add("Order nr.", 50, HorizontalAlignment.Left);

            listViewOrdersBarView.Columns.Add("Order description", 100, HorizontalAlignment.Left);

            listViewOrdersBarView.Columns.Add("Order time", 100, HorizontalAlignment.Left);

            foreach (OrderProduct orderProduct in orderProducts)
            {
                ListViewItem listViewItem = new ListViewItem(orderProduct.OrderNumber.ToString());

                //Add the tag used to update a record in the database
                listViewItem.Tag = orderProduct;

                //Add the values of the attributes to the listView
                listViewItem.SubItems.Add(orderProduct.ProductDescription.ToString());
                listViewItem.SubItems.Add(orderProduct.OrderTime.ToString());
                listViewOrdersBarView.Items.Add(listViewItem);
            }
        }
    }
}
