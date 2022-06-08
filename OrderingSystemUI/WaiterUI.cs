﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OrderingSystemLogic;
using OrderingSystemModel;

namespace OrderingSystemUI
{
    public partial class WaiterUI : Form
    {
        //create services
        OrderProductService orderProductService = new OrderProductService();
        ProductService productService = new ProductService();
        TableService tableService = new TableService();
        OrderService orderService = new OrderService();


        List<Product> addingNewOrdersList;
        List<int> alreadyPrinted = new List<int>();
        List<Product> lunchProducts;
        List<Product> dinnerProducts;
        List<Product> drinkProducts;




        Table currentTable = null;
        Employee currentEmployee = null;
        Order currentOrder = null;
        OrderProduct currentOrderItem;

        Product selectedProduct = null;
        Product selectedProductsOnAddList = null;

        Button tableButton = null;
        public WaiterUI(Employee currentEmployee)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;
            addingNewOrdersList = new List<Product>();

        }

        private void WaiterUI_Load(object sender, EventArgs e)
        {
            //Disables tabs in tabcontrol
            pnlPayment.Appearance = TabAppearance.FlatButtons;
            pnlPayment.ItemSize = new Size(0, 1);
            pnlPayment.SizeMode = TabSizeMode.Fixed;

            currentOrderItem = null;
            SetTablesColor();

            btnEmployeeName.Text = currentEmployee.EmployeeName;

            pnlPayment.SelectedTab = tableViewTabCommentQ;

            pnlTableStatus.Hide();
            pnlAddComment.Hide();

            lunchProducts = productService.GetLunchProducts();
            dinnerProducts = productService.GetDinnerProducts();
            drinkProducts = productService.GetDrinkProducts();

        }
        private void OrderOverview()
        {
            pnlPayment.SelectedTab = tableOrderOverviewTab;
            btnRemove.Hide();
            btnEdit.Hide();

            try
            {
                listViewTableOrder.Items.Clear();

                List<OrderProduct> products = orderProductService.GetAllOrderProducts();

                List<Product> productsForThisOrder = new List<Product>();
                List<int> alreadyPrinted = new List<int>();

                foreach (OrderProduct orderProduct in products)
                {
                    Order order = orderService.GetOrder(currentOrder.OrderNumber);
                    Product product = productService.GetProduct(orderProduct.ProductID);

                    if (orderProduct.OrderNumber == currentOrder.OrderNumber)
                    {
                        product.Status = orderProduct.Status;
                        productsForThisOrder.Add(product);
                    }

                }

                float total = 0;
                float vat = 0;
                foreach (Product product in productsForThisOrder)
                {
                    total += product.Price;
                    vat = vat + product.Price * product.VAT;
                    int count = 0;
                    foreach (Product p in productsForThisOrder)
                    {
                        if (p.ProductID == product.ProductID)
                        {
                            count++;
                        }
                    }

                    if (!alreadyPrinted.Contains(product.ProductID))
                    {


                        ListViewItem item = new ListViewItem();

                        if (product.Status == "prepared")
                           item.BackColor  = Color.Orange;
                        else if (product.Status == "served")
                            item.BackColor = Color.Green;

                        item.Text = $"{count} x"; //count
                        item.SubItems.Add(product.ProductName);//product name
                        item.SubItems.Add($"€ {product.Price.ToString("0.00")}");//price
                        item.Tag = product;
                        listViewTableOrder.Items.Add(item);
                    }
                    if (count > 1)
                        alreadyPrinted.Add(product.ProductID);

                }
                lblDisplayTotal.Text = "€ " + total.ToString("0.00");
                lblDisplayVAT.Text = vat.ToString("0.00");

            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured: ", e.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to discontinue the current process and go back to the table overview?", $"Going to table view", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                currentTable = null;
                tableNumber.Text = "TABLE#...";
                pnlTableStatus.Hide();
                pnlPayment.SelectedTab = tableViewTabCommentQ;
            }
            else
            {
                return;
            }
        }
        private void btnLunch_Click(object sender, EventArgs e)
        {
            LunchMenuDisplay();

        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            DinnerMenuDisplay();

        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            DrinksMenuDisplay();

        }
        private void btnDinnerMenu_Click(object sender, EventArgs e)
        {
            DinnerMenuDisplay();

        }
        private void btnLunchMenu_Click(object sender, EventArgs e)
        {
            LunchMenuDisplay();

        }

        private void btnDrinksMenu_Click(object sender, EventArgs e)
        {
            DrinksMenuDisplay();
        }

        private void LunchMenuDisplay()
        {
            pnlPayment.SelectedTab = addOrderView;
            listViewAddOrder.Items.Clear();
            listViewAddOrder.View = View.Tile;
            btnComment.Hide();
            btnRemoveNew.Hide();


            //List groups

            ListViewGroup lunchStarters = new ListViewGroup("Starters", HorizontalAlignment.Center);
            ListViewGroup lunchMains = new ListViewGroup("Mains", HorizontalAlignment.Center);
            ListViewGroup lunchDeserts = new ListViewGroup("Deserts", HorizontalAlignment.Center);

            foreach (Product product in lunchProducts)
            {
                ListViewGroup group;
                if (product.ProductType == "starters")
                    group = lunchStarters;
                else if (product.ProductType == "mains")
                    group = lunchMains;
                else if (product.ProductType == "deserts")
                    group = lunchDeserts;
                else throw new ArgumentException("Mistake in the database with the menu");

                ListViewItem item = new ListViewItem(product.ProductName, group);
                item.Tag = product;
                //item.Text = product.ProductName;
                //item.SubItems.Add($"€ {product.Price.ToString("0.00")}");//price

                listViewAddOrder.Items.Add(item);

            }
            listViewAddOrder.Groups.Add(lunchStarters);
            listViewAddOrder.Groups.Add(lunchMains);
            listViewAddOrder.Groups.Add(lunchDeserts);
        }
        private void DinnerMenuDisplay()
        {
            listViewAddOrder.Clear();

            pnlPayment.SelectedTab = addOrderView;
            listViewAddOrder.Items.Clear();
            listViewAddOrder.View = View.Tile;
            btnComment.Hide();
            btnRemoveNew.Hide();



            //List groups
            ListViewGroup dinnerStarters = new ListViewGroup("Starters", HorizontalAlignment.Center);
            ListViewGroup dinnerEntres = new ListViewGroup("Entres", HorizontalAlignment.Center);
            ListViewGroup dinnerMains = new ListViewGroup("Mains", HorizontalAlignment.Center);
            ListViewGroup dinnerDeserts = new ListViewGroup("Deserts", HorizontalAlignment.Center);

            foreach (Product product in dinnerProducts)
            {
                ListViewGroup group;
                if (product.ProductType == "starters")
                    group = dinnerStarters;
                else if (product.ProductType == "entrements")
                    group = dinnerEntres;
                else if (product.ProductType == "mains")
                    group = dinnerMains;
                else if (product.ProductType == "deserts")
                    group = dinnerDeserts;
                else throw new ArgumentException("Mistake in the database with the menu");

                ListViewItem item = new ListViewItem(product.ProductName, group);
                //item.Text = product.ProductName;
                //item.SubItems.Add($"€ {product.Price.ToString("0.00")}");//price
                item.Tag = product;

                listViewAddOrder.Items.Add(item);

            }
            listViewAddOrder.Groups.Add(dinnerStarters);
            listViewAddOrder.Groups.Add(dinnerEntres);
            listViewAddOrder.Groups.Add(dinnerMains);
            listViewAddOrder.Groups.Add(dinnerDeserts);
        }
        private void DrinksMenuDisplay()
        {
            listViewAddOrder.Clear();

            pnlPayment.SelectedTab = addOrderView;
            listViewAddOrder.Items.Clear();
            listViewAddOrder.View = View.Tile;
            btnComment.Hide();
            btnRemoveNew.Hide();

            //List groups
            ListViewGroup softDrinks = new ListViewGroup("Soft Drinks", HorizontalAlignment.Center);
            ListViewGroup beers = new ListViewGroup("Beers", HorizontalAlignment.Center);
            ListViewGroup wines = new ListViewGroup("Wines", HorizontalAlignment.Center);
            ListViewGroup spirits = new ListViewGroup("Spirits", HorizontalAlignment.Center);
            ListViewGroup hotDrinks = new ListViewGroup("Hot Drinks", HorizontalAlignment.Center);

            foreach (Product product in drinkProducts)
            {
                ListViewGroup group;
                if (product.ProductType == "soft drinks")
                    group = softDrinks;
                else if (product.ProductType == "beers")
                    group = beers;
                else if (product.ProductType == "wines")
                    group = wines;
                else if (product.ProductType == "spirits")
                    group = spirits;
                else if (product.ProductType == "coffe/tea")
                    group = hotDrinks;
                else throw new ArgumentException("Mistake in the database with the menu");

                ListViewItem item = new ListViewItem(product.ProductName, group);
                //item.Text = product.ProductName;
                //item.SubItems.Add($"€ {product.Price.ToString("0.00")}");//price
                item.Tag = product;

                listViewAddOrder.Items.Add(item);

            }
            listViewAddOrder.Groups.Add(softDrinks);
            listViewAddOrder.Groups.Add(beers);
            listViewAddOrder.Groups.Add(wines);
            listViewAddOrder.Groups.Add(spirits);
            listViewAddOrder.Groups.Add(hotDrinks);
        }

        private void lbl_contents_Click(object sender, EventArgs e)
        {

        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(1);
            currentOrder = orderService.GetOrder(currentTable.CurrentOrder);
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChangeStatus(currentTable.TableNumber, tableButton);
            pnlTableStatus.Hide();
            RBfree.Checked = false;
            RBoccupied.Checked = false;
            RBreserved.Checked = false;
        }

        public void ChangeStatus(int tableNumber, Button btn)
        {
            lblTableNumber.Text = tableNumber.ToString();
            Table table = tableService.GetTable(tableNumber);
            string tableStatus;


            if (RBfree.Checked)
            {
                tableStatus = "free";
                tableService.ChangeTableStatus(tableNumber, tableStatus);
                btn.BackColor = Color.PaleGreen;
            }
            else if (RBoccupied.Checked)
            {
                tableStatus = "occupied";
                tableService.ChangeTableStatus(tableNumber, tableStatus);
                btn.BackColor = Color.FromArgb(255, 128, 0);


                //code for creating new order every time a table is newly occupied so a new group of people can order with that ordernumber
                Order newOrder = new Order();
                newOrder.EmployeeNumber = currentEmployee.EmployeNumber;
                newOrder.OrderTime = DateTime.Now;
                int newCurrentOrder = orderService.CreateNewOrder(newOrder);
                currentTable.CurrentOrder = newCurrentOrder;
                tableService.UpdateTableWithCurrentOrder(currentTable, currentTable.CurrentOrder);
                MessageBox.Show("a new order has been creates");
            }
            else if (RBreserved.Checked)
            {
                tableStatus = "reserved";
                tableService.ChangeTableStatus(tableNumber, tableStatus);
                btn.BackColor = Color.DarkGray;
            }
        }

        public void SetTablesColor()
        {
            TableColor(tableService.GetTable(1), btnTable1);
            TableColor(tableService.GetTable(2), btnTable2);
            TableColor(tableService.GetTable(3), btnTable3);
            TableColor(tableService.GetTable(4), btnTable4);
            TableColor(tableService.GetTable(5), btnTable5);
            TableColor(tableService.GetTable(6), btnTable6);
            TableColor(tableService.GetTable(7), btnTable7);
            TableColor(tableService.GetTable(8), btnTable8);
            TableColor(tableService.GetTable(9), btnTable9);
            TableColor(tableService.GetTable(10), btnTable10);
        }

        public void TableColor(Table table, Button btn)
        {
            if (table.TableStatus == "free")
                btn.BackColor = Color.PaleGreen;
            else if (table.TableStatus == "occupied")
                btn.BackColor = Color.FromArgb(255, 128, 0);
            else if (table.TableStatus == "reserved")
                btn.BackColor = Color.DarkGray;
        }

        private void btnGoToTable_Click(object sender, EventArgs e)
        {
            ChangeStatus(currentTable.TableNumber, tableButton);
            tableNumber.Text = "TABLE " + currentTable.TableNumber;
            currentOrder = orderService.GetOrder(currentTable.CurrentOrder);
            OrderOverview();
            RBfree.Checked = false;
            RBoccupied.Checked = false;
            RBreserved.Checked = false;
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(2);
            tableButton = btnTable2;
            currentOrder = orderService.GetOrder(currentTable.CurrentOrder);
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(3);
            currentOrder = orderService.GetOrder(currentTable.CurrentOrder);
            tableButton = btnTable3;
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(4);
            currentOrder = orderService.GetOrder(currentTable.CurrentOrder);
            tableButton = btnTable4;
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;

        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(5);
            currentOrder = orderService.GetOrder(currentTable.CurrentOrder);
            tableButton = btnTable5;
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(6);
            currentOrder = orderService.GetOrder(currentTable.CurrentOrder);
            tableButton = btnTable6;
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(7);
            currentOrder = orderService.GetOrder(currentTable.CurrentOrder);
            tableButton = btnTable7;
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(8);
            currentOrder = orderService.GetOrder(currentTable.CurrentOrder);
            tableButton = btnTable8;
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(9);
            currentOrder = orderService.GetOrder(currentTable.CurrentOrder);
            tableButton = btnTable9;
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(10);
            currentOrder = orderService.GetOrder(currentTable.CurrentOrder);
            tableButton = btnTable10;
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnEmployeeName_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", $"See you soon {currentEmployee.EmployeeName}", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //log out and go back to login form
                //?currentEmployee == null;
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void listViewAddOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAddOrder.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewAddOrder.SelectedItems[0];
                selectedProduct = (Product)selectedItem.Tag; 
                addingNewOrdersList.Add(selectedProduct);

                DisplaySelectedItemsForOrder();
            }
        }
        private void DisplaySelectedItemsForOrder()
        {
            listViewOrderSummary.Items.Clear();
            alreadyPrinted = new List<int>();

            foreach (Product product in addingNewOrdersList)
            {
                int count = 0;
                foreach (Product p in addingNewOrdersList)
                {
                    if (p.ProductID == product.ProductID)
                    {
                        count++;
                    }
                }

                ListViewItem item = new ListViewItem();

                if (!alreadyPrinted.Contains(product.ProductID))
                {
                    item.Text = $"{count} x"; //count
                    item.SubItems.Add(product.ProductName);//product name
                    if(product.TemporaryComment != null)
                        item.SubItems.Add(product.TemporaryComment.ToString());
                    listViewOrderSummary.Items.Add(item);
                }
                item.Tag = product;
                alreadyPrinted.Add(product.ProductID);
                listViewAddOrder.SelectedItems.Clear();
            }
        }


        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            //add the created list of orderProducts to the actual order
            if (addingNewOrdersList.Count > 0)
            {
                for (int i = 0; i < addingNewOrdersList.Count; i++)
                {
                    if (addingNewOrdersList[i].TemporaryComment == null)
                        addingNewOrdersList[i].TemporaryComment = "";
                    orderProductService.AddOrderItem(currentOrder.OrderNumber, addingNewOrdersList[i].ProductID, addingNewOrdersList[i].TemporaryComment, DateTime.Now, "in preparation");
                    //edit stock in db
                    int newStock = addingNewOrdersList[i].Stock--;
                    productService.EditStock(addingNewOrdersList[i].ProductID, newStock);
                }
                for (int i = 0; i < addingNewOrdersList.Count; i++)
                {
                    addingNewOrdersList.Remove(addingNewOrdersList[i]);
                }
                //foreach (Product product in addingNewOrdersList)
                //{
                //    orderProductService.AddOrderItem(currentOrder.OrderNumber, product.ProductID, product.TemporaryComment, DateTime.Now, "in preparation");
                //    //edit stock in db
                //    int newStock = product.Stock--;
                //    productService.EditStock(product.ProductID, newStock);
                //    addingNewOrdersList.Remove(product);
                //}

            }

            OrderOverview();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //remove one item in the list
            DialogResult result = MessageBox.Show("Are you sure you want to remove this/these order Item(s)?", $"Item(s) removed", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                orderProductService.RemoveOrderItem(currentOrderItem.ProductID, currentOrderItem.OrderNumber);
                OrderOverview();
            }
            else
            {
                return;
            }
            listViewTableOrder.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void listViewTableOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Show();
            btnEdit.Show();
            if (listViewTableOrder.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = listViewTableOrder.SelectedItems[0];
                Product currentProduct = (Product)selectedItem.Tag;
                currentOrderItem = orderProductService.GetOrderProduct(currentOrder.OrderNumber, currentProduct.ProductID);

                if (listViewTableOrder.SelectedItems.Count > 1) btnEdit.Hide();
            }


        }

        //PAYMENT UI

        //method for displaying list of orders & price & VAT
        private void PaymentOrderOverview()
        {
            pnlPayment.SelectedTab = tabPagePayment;
           
            try
            {
                listViewTableOrder.Items.Clear();

                List<OrderProduct> products = orderProductService.GetAllOrderProducts();

                List<Product> productsForThisOrder = new List<Product>();
                List<int> alreadyPrinted = new List<int>();

                foreach (OrderProduct orderProduct in products)
                {
                    Order order = orderService.GetOrder(currentOrder.OrderNumber);
                    Product product = productService.GetProduct(orderProduct.ProductID);

                    if (order.OrderNumber == currentOrder.OrderNumber)
                    {
                        productsForThisOrder.Add(product);
                    }
                }
                float total = 0;
                float vat = 0;
                
               
                foreach (Product product in productsForThisOrder)
                {
                    total += product.Price;
                    vat = vat + product.Price * product.VAT;
                   
                    int count = 0;
                    foreach (Product p in productsForThisOrder)
                    {
                        if (p.ProductID == product.ProductID)
                        {
                            count++;
                        }
                    }

                    if (!alreadyPrinted.Contains(product.ProductID))
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = $"{count} x"; //count
                        item.SubItems.Add(product.ProductName);//product name
                        item.SubItems.Add($"€ {product.Price.ToString("0.00")}");//price

                        listViewPaymentOrder.Items.Add(item);
                    }
                    if (count > 1)
                        alreadyPrinted.Add(product.ProductID);

                }
                
                //display price
                lbl_price1.Text = "€ " + total.ToString("0.00");
                lbl_price2.Text = "€ " + total.ToString("0.00");
                lbl_price3.Text = "€ " + total.ToString("0.00");
                lbl_price4.Text = "€ " + total.ToString("0.00");

                //display vat
                lbl_vat_amount.Text = vat.ToString("0.00");
                lbl_vat_amount2.Text = vat.ToString("0.00");
                

            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured: ", e.Message);
            }
        }
        private void CalculateChange()
        {
            //DOESN'T WORK
           // int amountPaid = int.Parse(txtBox_amountPaid.Text);
            //int price = Int32.Parse(lbl_price3.Text);

           // int change = amountPaid - price;
            //lbl_change.Text = "€ " + change.ToString("0.00");
        }
        //navigate to Payment UI
        private void btnPay_Click(object sender, EventArgs e)
        {
            tableOrderOverviewTab.Hide();
            tabPagePayment.Show();
            PaymentOrderOverview();
        }
        private void radioBtn_DEBIT_CheckedChanged(object sender, EventArgs e)
        {
            
        }    
        //navigate to "PAYMENT OVERVIEW"
        private void btn_payment_Click(object sender, EventArgs e)
        {
            if (!radioBtn_CASH.Checked && !radioBtn_DEBIT.Checked && !radioBtn_VISA.Checked)
            {
                MessageBox.Show("To continue, please select payment type");
                return;
            }
            lbl_HasBeenAdded.Hide();
            tabPagePayment.Hide();
            tabPagePaymentView.Show();
        }
       
        private void btn_SetAmountPaid_Click(object sender, EventArgs e)
        {
            CalculateChange();
        }
        //navigate to "ANY COMMENTS?" page
        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (txtBox_amountPaid.Text == "")
            {
                MessageBox.Show("To continue the payment, you must fill in the amount paid by the customer!");
                return;
            }
            tabPagePaymentView.Hide();
            tabPageAnyComments.Show();
        }
        private void lbl9_Click(object sender, EventArgs e)
        {

        }
        //actions for "ANY COMMENTS?"
        private void btn_AddComment_Click(object sender, EventArgs e)
        {
            tabPageAnyComments.Hide();
            tabPageCustomerComment.Show();
        }
        //navigate to "SETTLE THE BILL" page
        private void btn_cntinuePayment_Click(object sender, EventArgs e)
        {
            tabPageAnyComments.Hide();
            tabPageSettledBill.Show();
        }
        //navigate to "SETTLE THE BILL" page
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
  

            if (txtBox_Comment.Text == "")
            {
                MessageBox.Show("To continue, please fill in the comment section!");
                return;
            }
            tabPageCustomerComment.Hide();
            tabPageSettledBill.Show();
        }
        //show label "TIP HAS BEEN ADDED" after adding change as a tip
        private void btn_changeAsTip_Click(object sender, EventArgs e)
        {
            lbl_HasBeenAdded.Show();
            btn_changeAsTip.Hide();
            lbl5.Hide();
            txtBox_CustomTip.Hide();
            btn_SetTip.Hide();
        }
        private void label_HasBeenAdded_Click(object sender, EventArgs e)
        {

        }
        //show label "TIP HAS BEEN ADDED" setting a customized tip
        private void btn_SetTip_Click(object sender, EventArgs e)
        {
            //display tip
            int customTip = int.Parse(txtBox_CustomTip.Text);
            lbl_tip3.Text = "€ " + customTip.ToString("0.00");

            lbl_HasBeenAdded.Show();
            btn_changeAsTip.Hide();
            lbl5.Hide();
            txtBox_CustomTip.Hide();
            btn_SetTip.Hide();
        }
        //go back from "COMMENTS" to "SETTLE THE BILL"
        private void btn_back_Click(object sender, EventArgs e)
        {
            tabPageCustomerComment.Hide();
            tabPagePaymentView.Show();
        }

        private void listViewPaymentOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtBox_Comment_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewOrderSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnComment.Show();
            btnRemoveNew.Show();

            if (listViewOrderSummary.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewOrderSummary.SelectedItems[0];
                selectedProductsOnAddList = (Product)selectedItem.Tag;
            }
        }

        private void btnRemoveNew_Click(object sender, EventArgs e)
        {
            addingNewOrdersList.Remove(selectedProductsOnAddList);
            DisplaySelectedItemsForOrder();
        }

        private void btnComment_Click_1(object sender, EventArgs e)
        {
            pnlAddComment.Show();
        }


        private void btnpnlAddComment_Click(object sender, EventArgs e)
        {
            string comment = txtboxComment.Text;
            selectedProductsOnAddList.TemporaryComment = comment;
            pnlAddComment.Hide();
            listViewOrderSummary.Items.Clear();
            DisplaySelectedItemsForOrder();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            pnlAddComment.Hide();
        }
    }
}



