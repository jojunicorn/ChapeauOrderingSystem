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

        Employee currentEmployee = null;

        public BarmanUI(Employee currentEmployee)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;
        }

        private void BarmanUI_Load(object sender, EventArgs e)
        {
            DisplayOrders();
            DisplayBarOrderStatus();
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

            listViewOrdersBarView.Columns.Add("Item ID", 70, HorizontalAlignment.Center);

            listViewOrdersBarView.Columns.Add("Order nr.", 70, HorizontalAlignment.Left);

            listViewOrdersBarView.Columns.Add("Order description", 470, HorizontalAlignment.Left);

            listViewOrdersBarView.Columns.Add("Order time", 200, HorizontalAlignment.Left);

            foreach (OrderProduct orderProduct in orderProducts)
            {
                ListViewItem listViewItem = new ListViewItem(orderProduct.ItemID.ToString());


                //Add the tag used to update a record in the database
                listViewItem.Tag = orderProduct;

                //Add the values of the attributes to the listView
                listViewItem.SubItems.Add(orderProduct.OrderNumber.ToString());
                listViewItem.SubItems.Add(orderProduct.ProductName.ToString());
                listViewItem.SubItems.Add(orderProduct.OrderTime.ToString());
                listViewOrdersBarView.Items.Add(listViewItem);
            }
        }

        private void DisplayBarOrderStatus()
        {

            // clear the listview before filling it again
            listViewBarOrderStatus.Clear();

            //set the listView to details view

            listViewBarOrderStatus.View = View.Details;


            // Select the item and subitems when selection is made.
            listViewBarOrderStatus.FullRowSelect = true;

            // Display grid lines.
            listViewBarOrderStatus.GridLines = true;


            //created the columns for the attributes of the order product

            listViewBarOrderStatus.Columns.Add("Item ID", 100, HorizontalAlignment.Center);

            listViewBarOrderStatus.Columns.Add("OrderStatus", 200, HorizontalAlignment.Left);

        }


        private void lbl_OrderStatusDisplay_Click(object sender, EventArgs e)
        {

        }

        private void Initialized_Click(object sender, EventArgs e)
        {
            OrderProduct orderProduct = (OrderProduct)listViewOrdersBarView.SelectedItems[0].Tag;

            orderProduct.Status = "in preparation";

            barViewService.UpdateOrderStatus((OrderProduct)listViewOrdersBarView.SelectedItems[0].Tag);

            ListViewItem item = new ListViewItem(orderProduct.ToString());
            item.Text = orderProduct.ItemID.ToString();
            item.SubItems.Add(orderProduct.Status.ToString());
            listViewBarOrderStatus.Items.Add(item);
        }

        private void InProgress_Click(object sender, EventArgs e)
        {
            OrderProduct orderProduct = (OrderProduct)listViewOrdersBarView.SelectedItems[0].Tag;

            orderProduct.Status = "prepared";

            barViewService.UpdateOrderStatus((OrderProduct)listViewOrdersBarView.SelectedItems[0].Tag);

            ListViewItem item = new ListViewItem(orderProduct.ToString());
            item.Text = orderProduct.ItemID.ToString();
            item.SubItems.Add(orderProduct.Status.ToString());
            listViewBarOrderStatus.Items.Add(item);
        }

        private void Completed_Click(object sender, EventArgs e)
        {
            OrderProduct orderProduct = (OrderProduct)listViewOrdersBarView.SelectedItems[0].Tag;

            orderProduct.Status = "served";

            barViewService.UpdateOrderStatus((OrderProduct)listViewOrdersBarView.SelectedItems[0].Tag);

            ListViewItem item = new ListViewItem(orderProduct.ToString());
            item.Text = orderProduct.ItemID.ToString();
            item.SubItems.Add(orderProduct.Status.ToString());
            listViewBarOrderStatus.Items.Add(item);

        }
    }
}
