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

            if (currentTable > 0)
            {
                tableNumber.Text = $"TABLE #{tableNumber}";
            }

            //testorder
            List<Order> orders = orderService.GetOrders();
            currentOrder = orders[0];
            OrderOverview();
        }
        private void OrderOverview()
        {
            tabControl.SelectedTab = tableOrderOverviewTab;

            try
            {
                listViewTableOrder.Items.Clear();

                List<OrderProduct> products = orderProductService.GetAllOrderProducts();
                foreach (OrderProduct product in products)
                {
                    if (product.OrderNumber == currentOrder)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = product.ProductID.ProductID.ToString(); //count
                        item.SubItems.Add(product.ProductID.ProductName);//product name
                        item.SubItems.Add($"product.ProductID.Price.ToString()");//price

                        listViewTableOrder.Items.Add(item);
                    }

                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error occured: ", e.Message) ;
            }
        }

    }
}
