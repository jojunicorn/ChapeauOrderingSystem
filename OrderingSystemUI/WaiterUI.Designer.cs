
namespace OrderingSystemUI
{
    partial class WaiterUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaiterUI));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tableViewTab1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableOrderOverviewTab = new System.Windows.Forms.TabPage();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnDinner = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.listViewTableOrder = new System.Windows.Forms.ListView();
            this.count = new System.Windows.Forms.ColumnHeader();
            this.itemName = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.addOrderView = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.listViewOrderSummary = new System.Windows.Forms.ListView();
            this.CHCount = new System.Windows.Forms.ColumnHeader();
            this.CHItemname = new System.Windows.Forms.ColumnHeader();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.listViewAddOrder = new System.Windows.Forms.ListView();
            this.btnDrinksMenu = new System.Windows.Forms.Button();
            this.btnDinnerMenu = new System.Windows.Forms.Button();
            this.btnLunchMenu = new System.Windows.Forms.Button();
            this.tabPagePayment = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEmployeeName = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableNumber = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tableOrderOverviewTab.SuspendLayout();
            this.addOrderView.SuspendLayout();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.AccessibleName = "TableView";
            this.tabControl.Controls.Add(this.tableViewTab1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tableOrderOverviewTab);
            this.tabControl.Controls.Add(this.addOrderView);
            this.tabControl.Controls.Add(this.tabPagePayment);
            this.tabControl.Controls.Add(this.tabPage8);
            this.tabControl.Location = new System.Drawing.Point(1, 47);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(421, 723);
            this.tabControl.TabIndex = 0;
            // 
            // tableViewTab1
            // 
            this.tableViewTab1.Location = new System.Drawing.Point(4, 29);
            this.tableViewTab1.Name = "tableViewTab1";
            this.tableViewTab1.Padding = new System.Windows.Forms.Padding(3);
            this.tableViewTab1.Size = new System.Drawing.Size(413, 690);
            this.tableViewTab1.TabIndex = 0;
            this.tableViewTab1.Text = "TableView";
            this.tableViewTab1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(413, 690);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TableView";
            // 
            // tableOrderOverviewTab
            // 
            this.tableOrderOverviewTab.BackColor = System.Drawing.Color.White;
            this.tableOrderOverviewTab.Controls.Add(this.lblVAT);
            this.tableOrderOverviewTab.Controls.Add(this.lblTotal);
            this.tableOrderOverviewTab.Controls.Add(this.btnPay);
            this.tableOrderOverviewTab.Controls.Add(this.btnDrinks);
            this.tableOrderOverviewTab.Controls.Add(this.btnDinner);
            this.tableOrderOverviewTab.Controls.Add(this.btnLunch);
            this.tableOrderOverviewTab.Controls.Add(this.listViewTableOrder);
            this.tableOrderOverviewTab.Location = new System.Drawing.Point(4, 29);
            this.tableOrderOverviewTab.Name = "tableOrderOverviewTab";
            this.tableOrderOverviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.tableOrderOverviewTab.Size = new System.Drawing.Size(413, 690);
            this.tableOrderOverviewTab.TabIndex = 2;
            this.tableOrderOverviewTab.Text = "TableOrderVIew";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVAT.Location = new System.Drawing.Point(237, 591);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(58, 28);
            this.lblVAT.TabIndex = 6;
            this.lblVAT.Text = "VAT: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(237, 563);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 28);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "TOTAL: ";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Location = new System.Drawing.Point(314, 634);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(90, 50);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // btnDrinks
            // 
            this.btnDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDrinks.Location = new System.Drawing.Point(287, 6);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(120, 50);
            this.btnDrinks.TabIndex = 3;
            this.btnDrinks.Text = "DRINKS";
            this.btnDrinks.UseVisualStyleBackColor = false;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnDinner
            // 
            this.btnDinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDinner.Location = new System.Drawing.Point(147, 6);
            this.btnDinner.Name = "btnDinner";
            this.btnDinner.Size = new System.Drawing.Size(120, 50);
            this.btnDinner.TabIndex = 2;
            this.btnDinner.Text = "DINNER";
            this.btnDinner.UseVisualStyleBackColor = false;
            this.btnDinner.Click += new System.EventHandler(this.btnDinner_Click);
            // 
            // btnLunch
            // 
            this.btnLunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLunch.Location = new System.Drawing.Point(7, 6);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(120, 50);
            this.btnLunch.TabIndex = 1;
            this.btnLunch.Text = "LUNCH";
            this.btnLunch.UseVisualStyleBackColor = false;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // listViewTableOrder
            // 
            this.listViewTableOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.count,
            this.itemName,
            this.Price});
            this.listViewTableOrder.FullRowSelect = true;
            this.listViewTableOrder.HideSelection = false;
            this.listViewTableOrder.Location = new System.Drawing.Point(7, 62);
            this.listViewTableOrder.Name = "listViewTableOrder";
            this.listViewTableOrder.Size = new System.Drawing.Size(400, 494);
            this.listViewTableOrder.TabIndex = 0;
            this.listViewTableOrder.UseCompatibleStateImageBehavior = false;
            this.listViewTableOrder.View = System.Windows.Forms.View.Details;
            // 
            // count
            // 
            this.count.Tag = "count";
            this.count.Text = "count";
            this.count.Width = 40;
            // 
            // itemName
            // 
            this.itemName.Text = "Product Name";
            this.itemName.Width = 270;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 80;
            // 
            // addOrderView
            // 
            this.addOrderView.Controls.Add(this.button2);
            this.addOrderView.Controls.Add(this.lblOrder);
            this.addOrderView.Controls.Add(this.listViewOrderSummary);
            this.addOrderView.Controls.Add(this.flowLayoutPanelMenu);
            this.addOrderView.Controls.Add(this.btnDrinksMenu);
            this.addOrderView.Controls.Add(this.btnDinnerMenu);
            this.addOrderView.Controls.Add(this.btnLunchMenu);
            this.addOrderView.Location = new System.Drawing.Point(4, 29);
            this.addOrderView.Name = "addOrderView";
            this.addOrderView.Padding = new System.Windows.Forms.Padding(3);
            this.addOrderView.Size = new System.Drawing.Size(413, 690);
            this.addOrderView.TabIndex = 3;
            this.addOrderView.Text = "AddOrderViewLunch";
            this.addOrderView.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(301, 646);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrder.Location = new System.Drawing.Point(6, 411);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(59, 17);
            this.lblOrder.TabIndex = 7;
            this.lblOrder.Text = "ORDER: ";
            // 
            // listViewOrderSummary
            // 
            this.listViewOrderSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHCount,
            this.CHItemname});
            this.listViewOrderSummary.HideSelection = false;
            this.listViewOrderSummary.Location = new System.Drawing.Point(7, 431);
            this.listViewOrderSummary.Name = "listViewOrderSummary";
            this.listViewOrderSummary.Size = new System.Drawing.Size(400, 211);
            this.listViewOrderSummary.TabIndex = 6;
            this.listViewOrderSummary.UseCompatibleStateImageBehavior = false;
            // 
            // CHCount
            // 
            this.CHCount.Text = "Count";
            // 
            // CHItemname
            // 
            this.CHItemname.Text = "Name";
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.Controls.Add(this.listViewAddOrder);
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(7, 62);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(400, 346);
            this.flowLayoutPanelMenu.TabIndex = 5;
            // 
            // listViewAddOrder
            // 
            this.listViewAddOrder.HideSelection = false;
            this.listViewAddOrder.Location = new System.Drawing.Point(3, 3);
            this.listViewAddOrder.Name = "listViewAddOrder";
            this.listViewAddOrder.Size = new System.Drawing.Size(364, 305);
            this.listViewAddOrder.TabIndex = 0;
            this.listViewAddOrder.UseCompatibleStateImageBehavior = false;
            // 
            // btnDrinksMenu
            // 
            this.btnDrinksMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDrinksMenu.Location = new System.Drawing.Point(287, 6);
            this.btnDrinksMenu.Name = "btnDrinksMenu";
            this.btnDrinksMenu.Size = new System.Drawing.Size(120, 50);
            this.btnDrinksMenu.TabIndex = 4;
            this.btnDrinksMenu.Text = "DRINKS";
            this.btnDrinksMenu.UseVisualStyleBackColor = false;
            // 
            // btnDinnerMenu
            // 
            this.btnDinnerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDinnerMenu.Location = new System.Drawing.Point(147, 6);
            this.btnDinnerMenu.Name = "btnDinnerMenu";
            this.btnDinnerMenu.Size = new System.Drawing.Size(120, 50);
            this.btnDinnerMenu.TabIndex = 3;
            this.btnDinnerMenu.Text = "DINNER";
            this.btnDinnerMenu.UseVisualStyleBackColor = false;
            // 
            // btnLunchMenu
            // 
            this.btnLunchMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLunchMenu.Location = new System.Drawing.Point(7, 6);
            this.btnLunchMenu.Name = "btnLunchMenu";
            this.btnLunchMenu.Size = new System.Drawing.Size(120, 50);
            this.btnLunchMenu.TabIndex = 2;
            this.btnLunchMenu.Text = "LUNCH";
            this.btnLunchMenu.UseVisualStyleBackColor = false;
            // 
            // tabPagePayment
            // 
            this.tabPagePayment.Location = new System.Drawing.Point(4, 29);
            this.tabPagePayment.Name = "tabPagePayment";
            this.tabPagePayment.Size = new System.Drawing.Size(413, 690);
            this.tabPagePayment.TabIndex = 6;
            this.tabPagePayment.Text = "Payment";
            this.tabPagePayment.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.button1);
            this.tabPage8.Controls.Add(this.pictureBox2);
            this.tabPage8.Location = new System.Drawing.Point(4, 29);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(413, 690);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "TableView";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 56);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnEmployeeName
            // 
            this.btnEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEmployeeName.Location = new System.Drawing.Point(319, 12);
            this.btnEmployeeName.Name = "btnEmployeeName";
            this.btnEmployeeName.Size = new System.Drawing.Size(94, 29);
            this.btnEmployeeName.TabIndex = 1;
            this.btnEmployeeName.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 56);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // tableNumber
            // 
            this.tableNumber.AutoSize = true;
            this.tableNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableNumber.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tableNumber.Location = new System.Drawing.Point(152, 13);
            this.tableNumber.Name = "tableNumber";
            this.tableNumber.Size = new System.Drawing.Size(121, 35);
            this.tableNumber.TabIndex = 2;
            this.tableNumber.Text = "Table #...";
            // 
            // WaiterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(425, 772);
            this.Controls.Add(this.tableNumber);
            this.Controls.Add(this.btnEmployeeName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tabControl);
            this.Name = "WaiterUI";
            this.Text = "WaiterUI";
            this.Load += new System.EventHandler(this.WaiterUI_Load);
            this.tabControl.ResumeLayout(false);
            this.tableOrderOverviewTab.ResumeLayout(false);
            this.tableOrderOverviewTab.PerformLayout();
            this.addOrderView.ResumeLayout(false);
            this.addOrderView.PerformLayout();
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tableViewTab1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tableOrderOverviewTab;
        private System.Windows.Forms.TabPage addOrderView;
        private System.Windows.Forms.Button btnEmployeeName;
        private System.Windows.Forms.TabPage tabPagePayment;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnDinner;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.ListView listViewTableOrder;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label tableNumber;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Button btnDrinksMenu;
        private System.Windows.Forms.Button btnDinnerMenu;
        private System.Windows.Forms.Button btnLunchMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ListView listViewOrderSummary;
        private System.Windows.Forms.ColumnHeader CHCount;
        private System.Windows.Forms.ColumnHeader CHItemname;
        private System.Windows.Forms.ListView listViewAddOrder;
    }
}