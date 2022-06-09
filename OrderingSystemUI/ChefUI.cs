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
            DisplayKitchenOrderStatus();
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
            listViewOrdersKitchenView.Columns.Add("Item ID", 70, HorizontalAlignment.Center);

            listViewOrdersKitchenView.Columns.Add("Order nr.", 70, HorizontalAlignment.Center);

            listViewOrdersKitchenView.Columns.Add("Order description", 470, HorizontalAlignment.Left);

            listViewOrdersKitchenView.Columns.Add("Order time", 200, HorizontalAlignment.Left);

            foreach (OrderProduct orderProduct in orderProducts)
            {
                ListViewItem listViewItem = new ListViewItem(orderProduct.ItemID.ToString());


                //Add the tag used to update a record in the database
                listViewItem.Tag = orderProduct;

                //Add the values of the attributes to the listView
                listViewItem.SubItems.Add(orderProduct.OrderNumber.ToString());
                listViewItem.SubItems.Add(orderProduct.ProductName.ToString());
                listViewItem.SubItems.Add(orderProduct.OrderTime.ToString());
                listViewOrdersKitchenView.Items.Add(listViewItem);
            }
        }

        private void DisplayKitchenOrderStatus() 
        {

            // clear the listview before filling it again
            listViewKitchenOrderStatus.Clear();

            //set the listView to details view

            listViewKitchenOrderStatus.View = View.Details;


            // Select the item and subitems when selection is made.
            listViewKitchenOrderStatus.FullRowSelect = true;

            // Display grid lines.
            listViewKitchenOrderStatus.GridLines = true;


            //created the columns for the attributes of the order product

            listViewKitchenOrderStatus.Columns.Add("Item ID", 100, HorizontalAlignment.Center);

            listViewKitchenOrderStatus.Columns.Add("OrderStatus", 200, HorizontalAlignment.Left);

        }

        private void btnInitialized_Click(object sender, EventArgs e)
        {
            OrderProduct orderProduct = (OrderProduct)listViewOrdersKitchenView.SelectedItems[0].Tag;

            orderProduct.Status = "in preparation";

            kitchenViewService.UpdateOrderStatus(orderProduct);

            ListViewItem item = new ListViewItem(orderProduct.ToString());
            item.Text = orderProduct.ItemID.ToString();
            item.SubItems.Add(orderProduct.Status.ToString());
            listViewKitchenOrderStatus.Items.Add(item);
        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            OrderProduct orderProduct = (OrderProduct)listViewOrdersKitchenView.SelectedItems[0].Tag;

            orderProduct.Status = "prepared";

            kitchenViewService.UpdateOrderStatus((OrderProduct)listViewOrdersKitchenView.SelectedItems[0].Tag);

            ListViewItem item = new ListViewItem(orderProduct.ToString());
            item.Text = orderProduct.ItemID.ToString();
            item.SubItems.Add(orderProduct.Status.ToString());
            listViewKitchenOrderStatus.Items.Add(item);
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            OrderProduct orderProduct = (OrderProduct)listViewOrdersKitchenView.SelectedItems[0].Tag;

            orderProduct.Status = "served";

            kitchenViewService.UpdateOrderStatus((OrderProduct)listViewOrdersKitchenView.SelectedItems[0].Tag);

            ListViewItem item = new ListViewItem(orderProduct.ToString());
            item.Text = orderProduct.ItemID.ToString();
            item.SubItems.Add(orderProduct.Status.ToString());
            listViewKitchenOrderStatus.Items.Add(item);
        }
    }
}
