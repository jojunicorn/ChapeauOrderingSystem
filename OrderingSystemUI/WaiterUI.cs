using System;
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

        Table currentTable = null;
        Employee currentEmployee = null;
        Order currentOrder = null;
        OrderProduct currentOrderItem = null;

        Product selectedProduct = null;

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
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;

            SetTablesColor();

            btnEmployeeName.Text = currentEmployee.EmployeeName;

            tabControl.SelectedTab = tableViewTab;


            //currentOrder = orderService.GetOrder(2);
            //currentTable = tableService.GetTable(1); ///for test


            //OrderOverview();
            pnlTableStatus.Hide();

        }
        private void OrderOverview()
        {
            tabControl.SelectedTab = tableOrderOverviewTab;
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
                    //Order order = orderService.GetOrder(currentTable.CurrentOrder);
                    Order order = orderService.GetOrder(currentOrder.OrderNumber);
                    Product product = productService.GetProduct(orderProduct.ProductID);

                    if (order.OrderNumber == currentOrder.OrderNumber)
                    {
                        //product.Status = orderProduct.Status;
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
                            //productsForThisOrder.Remove(product);
                        }
                    }

                    if (!alreadyPrinted.Contains(product.ProductID))
                    {
                        //if (product.Status == "prepared")
                        //    Console.ForegroundColor = ConsoleColor.DarkYellow;
                        //else if (product.Status == "served")
                        //    Console.ForegroundColor = ConsoleColor.Green;
                            ListViewItem item = new ListViewItem();
                        item.Text = $"{count} x"; //count
                        item.SubItems.Add(product.ProductName);//product name
                        item.SubItems.Add($"€ {product.Price.ToString("0.00")}");//price

                        listViewTableOrder.Items.Add(item);
                        //Console.ResetColor();
                    }
                    if (count > 1)
                        alreadyPrinted.Add(product.ProductID);

                }
                lblDisplayTotal.Text = "€ "+ total.ToString("0.00");
                lblDisplayVAT.Text = vat.ToString("0.00");
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured: ", e.Message);
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
            tabControl.SelectedTab = addOrderView;
            listViewAddOrder.Items.Clear();
            listViewAddOrder.View = View.Tile;
            //List groups

            ListViewGroup lunchStarters = new ListViewGroup("Starters", HorizontalAlignment.Center);
            ListViewGroup lunchMains = new ListViewGroup("Mains", HorizontalAlignment.Center);
            ListViewGroup lunchDeserts = new ListViewGroup("Deserts", HorizontalAlignment.Center);

            List<Product> lunchProducts = productService.GetLunchProducts();
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
            tabControl.SelectedTab = addOrderView;
            listViewAddOrder.Items.Clear();
            listViewAddOrder.View = View.Tile;

            //List groups
            ListViewGroup dinnerStarters = new ListViewGroup("Starters", HorizontalAlignment.Center);
            ListViewGroup dinnerEntres = new ListViewGroup("Entres", HorizontalAlignment.Center);
            ListViewGroup dinnerMains = new ListViewGroup("Mains", HorizontalAlignment.Center);
            ListViewGroup dinnerDeserts = new ListViewGroup("Deserts", HorizontalAlignment.Center);

            List<Product> dinnerProducts = productService.GetDinnerProducts();
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

                listViewAddOrder.Items.Add(item);

            }
            listViewAddOrder.Groups.Add(dinnerStarters);
            listViewAddOrder.Groups.Add(dinnerEntres);
            listViewAddOrder.Groups.Add(dinnerMains);
            listViewAddOrder.Groups.Add(dinnerDeserts);
        }
        private void DrinksMenuDisplay()
        {
            tabControl.SelectedTab = addOrderView;
            listViewAddOrder.Items.Clear();
            listViewAddOrder.View = View.Tile;

            //List groups
            ListViewGroup softDrinks = new ListViewGroup("Soft Drinks", HorizontalAlignment.Center);
            ListViewGroup beers = new ListViewGroup("Beers", HorizontalAlignment.Center);
            ListViewGroup wines = new ListViewGroup("Wines", HorizontalAlignment.Center);
            ListViewGroup spirits = new ListViewGroup("Spirits", HorizontalAlignment.Center);
            ListViewGroup hotDrinks = new ListViewGroup("Hot Drinks", HorizontalAlignment.Center);

            List<Product> drinkProducts = productService.GetDrinkProducts();
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
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChangeStatus(currentTable.TableNumber, tableButton);
            pnlTableStatus.Hide();
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
                tableService.UpdateTableWithCurrentOrder(currentTable, newCurrentOrder);
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
            //tabControl.SelectedTab = addOrderView;
            tableNumber.Text = "TABLE " + currentTable.TableNumber;
            currentOrder = orderService.GetOrder(currentTable.CurrentOrder);
            OrderOverview();
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(2);
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(3);
            tableButton = btnTable3;
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(4);
            tableButton = btnTable4;
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
            
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(5);
            tableButton = btnTable5;
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(6);
            tableButton = btnTable6;
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(7);
            tableButton = btnTable7;
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(8);
            tableButton = btnTable8;
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(9);
            tableButton = btnTable9;
            lblTableNumber.Text = "TABLE " + currentTable.TableNumber;
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            pnlTableStatus.Show();
            currentTable = tableService.GetTable(10);
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
                this.Close();
            }
            else
            {
                return;
            }
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            
        }

        private void tableNumber_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to discontinue the current process?", $"Going to table view", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                currentTable = null;
                tableNumber.Text = "TABLE#...";
                pnlTableStatus.Hide();
                tabControl.SelectedTab = tableViewTab;
            }
            else
            {
                return;
            }
        }

        private void listViewAddOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listViewAddOrder.SelectedItems[0];

            //if (listViewAddOrder.SelectedItems.Count > 1)
            //{
            //    listViewAddOrder.SelectedItems.Clear();
            //    listViewAddOrder_SelectedIndexChanged(sender,e);
            //}

            selectedProduct = TagReplacement(productService.GetAllProducts(), selectedItem);
            addingNewOrdersList.Add(selectedProduct);

            List<int> alreadyPrinted = new List<int>();

            foreach (Product product in addingNewOrdersList)
            {

                int count = 0;
                foreach (Product p in addingNewOrdersList)
                {
                    if (p.ProductID == product.ProductID)
                    {
                        count++;
                        //productsForThisOrder.Remove(product);
                    }
                }

                if (!alreadyPrinted.Contains(product.ProductID))
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = $"{count} x"; //count
                    item.SubItems.Add(product.ProductName);//product name

                    listViewOrderSummary.Items.Add(item);
                }

                alreadyPrinted.Add(product.ProductID);
            }
        }

        private Product TagReplacement(List<Product> products, ListViewItem item)
        {

            foreach (Product product in products)
            {
                if (item.Text == product.ProductName)
                    return product;
            }
            throw new Exception();
        }


        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            //add the created list of orderProducts to the actual order
            if (addingNewOrdersList.Count > 0)
            {
                foreach (Product product in addingNewOrdersList)
                {
                    orderProductService.AddOrderItem(currentOrder.OrderNumber, product.ProductID, "", DateTime.Now, "in preparation");
                    product.Stock--;
                }

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
            ListViewItem selectedItem = listViewAddOrder.SelectedItems[0];
            currentOrderItem = (OrderProduct)selectedItem.Tag;

            if (listViewTableOrder.SelectedItems.Count > 1) btnEdit.Hide();

        }
    }
}


