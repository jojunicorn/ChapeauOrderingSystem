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
    public partial class ChefUI : Form
    {
        KitchenViewService kitchenViewService = new KitchenViewService();
        List<OrderProduct> orderProducts;

        Employee currentEmployee = null;

        public ChefUI(Employee currentEmployee)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;
        }

        private void listBoxKitchenViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChefUI_Load(object sender, EventArgs e)
        {
            DisplayOrders();

        }

        private void DisplayOrders()
        {
            orderProducts = kitchenViewService.GetOrders();
            // clear the listview before filling it again
            listViewOrdersKitchenView.Clear();

            //set the listView to details view

            listViewOrdersKitchenView.View = View.Details;


            // Select the item and subitems when selection is made.
            listViewOrdersKitchenView.FullRowSelect = true;

            // Display grid lines.
            listViewOrdersKitchenView.GridLines = true;


            //created the columns for the attributes of the order product

            listViewOrdersKitchenView.Columns.Add("Order nr.", 100, HorizontalAlignment.Center);

            listViewOrdersKitchenView.Columns.Add("Order description", 470, HorizontalAlignment.Left);

            listViewOrdersKitchenView.Columns.Add("Order time", 200, HorizontalAlignment.Left);

            foreach (OrderProduct orderProduct in orderProducts)
            {
                ListViewItem listViewItem = new ListViewItem(orderProduct.OrderNumber.ToString());


                //Add the tag used to update a record in the database
                listViewItem.Tag = orderProduct;

                //Add the values of the attributes to the listView
                listViewItem.SubItems.Add(orderProduct.ProductName.ToString());
                listViewItem.SubItems.Add(orderProduct.OrderTime.ToString());
                listViewOrdersKitchenView.Items.Add(listViewItem);
            }

        }
    }
}
