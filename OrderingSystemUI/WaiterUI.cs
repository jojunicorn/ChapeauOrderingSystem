using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OrderingSystemLogic;
using OrderingSystemModel;

namespace OrderingSystemUI
{
    public partial class WaiterUI : Form
    {
        OrderProductService orderProductService = new OrderProductService();
        ProductService productService = new ProductService();
        TableService tableService = new TableService();
        OrderService orderService = new OrderService();
        


        int currentTable = 0;
        Employee currentEmployee = null;
        Order currentOrder = null; 
        public WaiterUI(Employee currentEmployee)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;
        }

        private void WaiterUI_Load(object sender, EventArgs e)
        {
            //Disables tabs in tabcontrol
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;

            btnEmployeeName.Text = "";//currentEmployee.EmployeeName;

            currentOrder = orderService.GetOrder(1);
            currentTable = 1; ///for test
            if (currentTable > 0)
            {
                tableNumber.Text = $"TABLE #{currentTable}";
            }

            OrderOverview();
        }
        private void OrderOverview()
        {
            tabControl.SelectedTab = tableOrderOverviewTab;

            try
            {
                listViewTableOrder.Items.Clear();

                List<OrderProduct> products = orderProductService.GetAllOrderProducts();
                foreach (OrderProduct orderProduct in products)
                {
                Order order = orderService.GetOrder(orderProduct.OrderNumber);
                Product product = productService.GetProduct(orderProduct.ProductID); 
                    
                    if (order.OrderNumber == currentOrder.OrderNumber)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = "testx"; //count
                        item.SubItems.Add(product.ProductName);//product name
                        item.SubItems.Add($"€ {product.Price.ToString("0.00")}");//price

                        listViewTableOrder.Items.Add(item);
                    }

                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error occured: ", e.Message) ;
            }
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = addOrderView;
            
            //List groups

            ListViewGroup lunchStarters = new ListViewGroup("Starters", HorizontalAlignment.Center);
            ListViewGroup lunchMains = new ListViewGroup("Mains", HorizontalAlignment.Center);
            ListViewGroup lunchDeserts = new ListViewGroup("Deserts", HorizontalAlignment.Center);

        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = addOrderView;
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

                ListViewItem item = new ListViewItem($"{product.ProductName} {product.Price}", group);

                listViewTableOrder.Items.Add(item);
            }
            listViewAddOrder.Groups.Add(dinnerStarters);
            listViewAddOrder.Groups.Add(dinnerEntres);
            listViewAddOrder.Groups.Add(dinnerMains);
            listViewAddOrder.Groups.Add(dinnerDeserts);
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = addOrderView;

            //List groups
            ListViewGroup softDrinks = new ListViewGroup("Soft Drinks", HorizontalAlignment.Center);
            ListViewGroup beers = new ListViewGroup("Beers", HorizontalAlignment.Center);
            ListViewGroup wines = new ListViewGroup("Wines", HorizontalAlignment.Center);
            ListViewGroup spirits = new ListViewGroup("Spirits", HorizontalAlignment.Center);
            ListViewGroup hotDrinks = new ListViewGroup("Hot Drinks", HorizontalAlignment.Center);

        }
    }
}
