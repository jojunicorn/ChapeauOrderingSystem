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
    public partial class BartenderAndChefUI : Form
    {
        KitchenAndBarService kitchenViewService = new KitchenAndBarService();
        List<OrderProduct> orderProducts;
        Employee currentEmployee = null;
        string[] employeeFullName = null;
        

        public BartenderAndChefUI(Employee currentEmployee)
        {
                InitializeComponent();
                this.currentEmployee = currentEmployee;
        }


       
        private void DisplayBarOrders()
        {
            orderProducts = kitchenViewService.GetBarOrders();

            // clear the listview before filling it again
            listViewOrders.Clear();

            //set the listView to details view

            listViewOrders.View = View.Details;

            // Select the item and subitems when selection is made.
            listViewOrders.FullRowSelect = true;

            // Display grid lines.
            listViewOrders.GridLines = true;

            //created the columns for the attributes of the order product
            listViewOrders.Columns.Add("Item ID", 75, HorizontalAlignment.Center);

            listViewOrders.Columns.Add("Order nr.", 110, HorizontalAlignment.Left);

            listViewOrders.Columns.Add("Order description", 470, HorizontalAlignment.Left);

            listViewOrders.Columns.Add("Order time", 200, HorizontalAlignment.Left);

            //adding the bar orders to the list of orders
            foreach (OrderProduct orderProduct in orderProducts)
            {
                ListViewItem listViewItem = new ListViewItem(orderProduct.ItemID.ToString());

                listViewItem.Tag = orderProduct;

                //adding the values of the orderProduct attributes to the listView
                listViewItem.SubItems.Add(orderProduct.OrderNumber.ToString());
                listViewItem.SubItems.Add(orderProduct.ProductName.ToString());
                listViewItem.SubItems.Add(orderProduct.OrderTime.ToString());
                listViewOrders.Items.Add(listViewItem);
            }
        }


        private void DisplayOrderStatus()
        {

            // clear the listview before filling it again
            listViewOrdersStatus.Clear();

            //set the listView to details view

            listViewOrdersStatus.View = View.Details;

            // Select the item and subitems when selection is made.
            listViewOrdersStatus.FullRowSelect = true;

            // Display grid lines.
            listViewOrdersStatus.GridLines = true;

            //created the columns for the attributes of the order product

            listViewOrdersStatus.Columns.Add("Item ID", 75, HorizontalAlignment.Center);

            listViewOrdersStatus.Columns.Add("Order description", 250, HorizontalAlignment.Center);

            listViewOrdersStatus.Columns.Add("OrderStatus", 110, HorizontalAlignment.Left);
        }


        private void DisplayKitchenOrders()
        {
            orderProducts = kitchenViewService.GetKitchenOrders();

            // clear the listview before filling it again
            listViewOrders.Clear();

            //set the listView to details view

            listViewOrders.View = View.Details;

            // Select the item and subitems when selection is made.
            listViewOrders.FullRowSelect = true;

            // Display grid lines.
            listViewOrders.GridLines = true;


            //created the columns for the attributes of the order product
            listViewOrders.Columns.Add("Item ID", 75, HorizontalAlignment.Center);

            listViewOrders.Columns.Add("Order nr.", 110, HorizontalAlignment.Center);

            listViewOrders.Columns.Add("Order description", 470, HorizontalAlignment.Left);

            listViewOrders.Columns.Add("Order time", 200, HorizontalAlignment.Left);


            //adding the kitchen orders to the list of orders
            foreach (OrderProduct orderProduct in orderProducts)
            {
                ListViewItem listViewItem = new ListViewItem(orderProduct.ItemID.ToString());

                listViewItem.Tag = orderProduct;

                //Add the values of the orderProduct attributes to the listView
                listViewItem.SubItems.Add(orderProduct.OrderNumber.ToString());
                listViewItem.SubItems.Add(orderProduct.ProductName.ToString());
                listViewItem.SubItems.Add(orderProduct.OrderTime.ToString());
                listViewOrders.Items.Add(listViewItem);
            }
        }

       
        private void btnInitialized_Click(object sender, EventArgs e)
        {
            bool initialized = false;
            bool selected = true;
            
            try
            {
                //checking if the user doesn't select one order and tries to set one order's status
                if (!(listViewOrders.SelectedItems.Count > 0))
                {
                    selected = false;
                    throw new Exception();
                }
                
                //save the order product that is selected
                OrderProduct orderProduct = (OrderProduct)listViewOrders.SelectedItems[0].Tag;

                //checking if the user has already set the status to 'in preparation'
                if (orderProduct.Status == "in preparation")
                { 
                  initialized = true;
                  throw new Exception();
                }
              
                orderProduct.Status = "in preparation";

                kitchenViewService.UpdateOrderStatus(orderProduct);

                //removing previous item from the list with orders status
                listViewOrdersStatus.Items.Clear();

                //displaying that the order status was changed to 'in preparation'
                ListViewItem item = new ListViewItem(orderProduct.ToString());
                item.Text = orderProduct.ItemID.ToString();
                item.SubItems.Add(orderProduct.ProductName);
                item.SubItems.Add(orderProduct.Status.ToString());
                listViewOrdersStatus.Items.Add(item);

            }
            catch 
            {
                //display error message if the user doesn't set correctly the order status
                if(initialized == true)
                { MessageBox.Show("Order product status is 'initialized'"); }
                else if(selected == false) 
                { MessageBox.Show("No order from the orders list was selected "); }
            }
        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            bool selected = true;

            try
            {   
                //checking if the user doesn't select one order and tries to set one order's status
                if (!(listViewOrders.SelectedItems.Count > 0))
                {
                    selected = false;
                    throw new Exception();
                }

                OrderProduct orderProduct = (OrderProduct)listViewOrders.SelectedItems[0].Tag;

                orderProduct.Status = "prepared";

                kitchenViewService.UpdateOrderStatus(orderProduct);

                //removing item from list of orders after it is prepared
                ListViewItem processedItem = listViewOrders.SelectedItems[0];
                listViewOrders.Items.Remove(processedItem);

                //removing previous item from the list with orders status
                listViewOrdersStatus.Items.Clear();

                //displaying that the order status was changed to 'prepared'
                ListViewItem item = new ListViewItem(orderProduct.ItemID.ToString());
                item.Tag = orderProduct;
                item.SubItems.Add(orderProduct.ProductName);
                item.SubItems.Add(orderProduct.Status.ToString());
                listViewOrdersStatus.Items.Add(item);

                lblComment.Text = "";
            }
            catch
            {
                //display error message if the user doesn't set correctly the order status
                 if (selected == false)
                { MessageBox.Show("No order from the orders list was selected "); }
            }
        }



        private void listViewOrdersKitchenView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 0) { return; }
            else 
            {
                //save the order that is selected and display the comment for the order
                OrderProduct orderProduct = (OrderProduct)listViewOrders.SelectedItems[0].Tag;
                lblComment.Text = orderProduct.Comment;
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", $"See you soon {currentEmployee.EmployeeName}", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //log out and go back to login form
                //?currentEmployee == null;
                Close();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();  
            }
            else
            {
                return;
            }
        }

        public string GetEmployeeFirstName() 
        {
            employeeFullName = this.currentEmployee.EmployeeName.Split();
            if (this.currentEmployee.EmployeeName.Contains(' ')) { return employeeFullName[0];}
            return this.currentEmployee.EmployeeName;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {   //display kitchen orders if new orders were made
                if (this.currentEmployee.EmployeePosition == "chef")
                {
                    DisplayKitchenOrders();
                }
                //display bar orders if new orders were made
                else if (this.currentEmployee.EmployeePosition == "bartender")
                {
                    DisplayBarOrders();
                }
            }
            catch
            {
                MessageBox.Show("An error occured while displaying the orders");
            }
        }

        private void BartenderAndChefUI_Load(object sender, EventArgs e)
        {
            try
            {
                //display the kitchen orders if the logged in user is a chef
                if (this.currentEmployee.EmployeePosition == "chef")
                {
                    DisplayKitchenOrders();
                }
                //display the bar orders if the logged in user is a bartender
                else if (this.currentEmployee.EmployeePosition == "bartender")
                {
                    DisplayBarOrders();
                }
                DisplayOrderStatus();

                //display the first name of the user that is logged in
                btnEmployee.Text = GetEmployeeFirstName();
            }
            catch
            {
                MessageBox.Show("An error occured while displaying the orders");
            }
        }
    }
}
