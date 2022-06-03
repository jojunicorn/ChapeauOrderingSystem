
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaiterUI));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tableViewTab = new System.Windows.Forms.TabPage();
            this.pnlTableStatus = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGoToTable = new System.Windows.Forms.Button();
            this.RBreserved = new System.Windows.Forms.RadioButton();
            this.RBoccupied = new System.Windows.Forms.RadioButton();
            this.RBfree = new System.Windows.Forms.RadioButton();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.btnTable10 = new System.Windows.Forms.Button();
            this.btnTable9 = new System.Windows.Forms.Button();
            this.btnTable8 = new System.Windows.Forms.Button();
            this.btnTable7 = new System.Windows.Forms.Button();
            this.btnTable6 = new System.Windows.Forms.Button();
            this.btnTable5 = new System.Windows.Forms.Button();
            this.btnTable4 = new System.Windows.Forms.Button();
            this.btnTable3 = new System.Windows.Forms.Button();
            this.btnTable2 = new System.Windows.Forms.Button();
            this.btnTable1 = new System.Windows.Forms.Button();
            this.tableOrderOverviewTab = new System.Windows.Forms.TabPage();
            this.lblDisplayVAT = new System.Windows.Forms.Label();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
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
            this.btnComment = new System.Windows.Forms.Button();
            this.pnlComment = new System.Windows.Forms.Panel();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.txtboxComment = new System.Windows.Forms.TextBox();
            this.listViewAddOrder = new System.Windows.Forms.ListView();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chPrice = new System.Windows.Forms.ColumnHeader();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.listViewOrderSummary = new System.Windows.Forms.ListView();
            this.CHCount = new System.Windows.Forms.ColumnHeader();
            this.CHItemname = new System.Windows.Forms.ColumnHeader();
            this.btnDrinksMenu = new System.Windows.Forms.Button();
            this.btnDinnerMenu = new System.Windows.Forms.Button();
            this.btnLunchMenu = new System.Windows.Forms.Button();
            this.tabPagePayment = new System.Windows.Forms.TabPage();
            this.btn_payment = new System.Windows.Forms.Button();
            this.lbl_vat_amount = new System.Windows.Forms.Label();
            this.lbl_VAT = new System.Windows.Forms.Label();
            this.lbl_price1 = new System.Windows.Forms.Label();
            this.lbl_price2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_VISA = new System.Windows.Forms.Button();
            this.btn_DEBIT = new System.Windows.Forms.Button();
            this.lbl_crditCardType = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_contents = new System.Windows.Forms.Label();
            this.lbl_bill = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.btnEmployeeName = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tableViewTab.SuspendLayout();
            this.pnlTableStatus.SuspendLayout();
            this.tableOrderOverviewTab.SuspendLayout();
            this.addOrderView.SuspendLayout();
            this.pnlComment.SuspendLayout();
            this.tabPagePayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.AccessibleName = "TableView";
            this.tabControl.Controls.Add(this.tableViewTab);
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
            // tableViewTab
            // 
            this.tableViewTab.Controls.Add(this.pnlTableStatus);
            this.tableViewTab.Controls.Add(this.label7);
            this.tableViewTab.Controls.Add(this.label6);
            this.tableViewTab.Controls.Add(this.label5);
            this.tableViewTab.Controls.Add(this.label4);
            this.tableViewTab.Controls.Add(this.label3);
            this.tableViewTab.Controls.Add(this.label2);
            this.tableViewTab.Controls.Add(this.btnTable10);
            this.tableViewTab.Controls.Add(this.btnTable9);
            this.tableViewTab.Controls.Add(this.btnTable8);
            this.tableViewTab.Controls.Add(this.btnTable7);
            this.tableViewTab.Controls.Add(this.btnTable6);
            this.tableViewTab.Controls.Add(this.btnTable5);
            this.tableViewTab.Controls.Add(this.btnTable4);
            this.tableViewTab.Controls.Add(this.btnTable3);
            this.tableViewTab.Controls.Add(this.btnTable2);
            this.tableViewTab.Controls.Add(this.btnTable1);
            this.tableViewTab.Location = new System.Drawing.Point(4, 29);
            this.tableViewTab.Name = "tableViewTab";
            this.tableViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.tableViewTab.Size = new System.Drawing.Size(413, 690);
            this.tableViewTab.TabIndex = 0;
            this.tableViewTab.Text = "TableView";
            this.tableViewTab.UseVisualStyleBackColor = true;
            // 
            // pnlTableStatus
            // 
            this.pnlTableStatus.Controls.Add(this.btnBack);
            this.pnlTableStatus.Controls.Add(this.btnGoToTable);
            this.pnlTableStatus.Controls.Add(this.RBreserved);
            this.pnlTableStatus.Controls.Add(this.RBoccupied);
            this.pnlTableStatus.Controls.Add(this.RBfree);
            this.pnlTableStatus.Controls.Add(this.lblTableNumber);
            this.pnlTableStatus.Location = new System.Drawing.Point(19, 84);
            this.pnlTableStatus.Name = "pnlTableStatus";
            this.pnlTableStatus.Size = new System.Drawing.Size(374, 587);
            this.pnlTableStatus.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(0, 500);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGoToTable
            // 
            this.btnGoToTable.BackColor = System.Drawing.Color.White;
            this.btnGoToTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoToTable.Location = new System.Drawing.Point(112, 368);
            this.btnGoToTable.Name = "btnGoToTable";
            this.btnGoToTable.Size = new System.Drawing.Size(146, 43);
            this.btnGoToTable.TabIndex = 4;
            this.btnGoToTable.Text = "Go to table";
            this.btnGoToTable.UseVisualStyleBackColor = false;
            this.btnGoToTable.Click += new System.EventHandler(this.btnGoToTable_Click);
            // 
            // RBreserved
            // 
            this.RBreserved.AutoSize = true;
            this.RBreserved.BackColor = System.Drawing.Color.DarkGray;
            this.RBreserved.Location = new System.Drawing.Point(243, 277);
            this.RBreserved.Name = "RBreserved";
            this.RBreserved.Size = new System.Drawing.Size(100, 24);
            this.RBreserved.TabIndex = 3;
            this.RBreserved.TabStop = true;
            this.RBreserved.Text = "RESERVED";
            this.RBreserved.UseVisualStyleBackColor = false;
            // 
            // RBoccupied
            // 
            this.RBoccupied.AutoSize = true;
            this.RBoccupied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RBoccupied.Location = new System.Drawing.Point(124, 277);
            this.RBoccupied.Name = "RBoccupied";
            this.RBoccupied.Size = new System.Drawing.Size(100, 24);
            this.RBoccupied.TabIndex = 2;
            this.RBoccupied.TabStop = true;
            this.RBoccupied.Text = "OCCUPIED";
            this.RBoccupied.UseVisualStyleBackColor = false;
            // 
            // RBfree
            // 
            this.RBfree.AutoSize = true;
            this.RBfree.BackColor = System.Drawing.Color.PaleGreen;
            this.RBfree.Location = new System.Drawing.Point(36, 277);
            this.RBfree.Name = "RBfree";
            this.RBfree.Size = new System.Drawing.Size(62, 24);
            this.RBfree.TabIndex = 1;
            this.RBfree.TabStop = true;
            this.RBfree.Text = "FREE";
            this.RBfree.UseVisualStyleBackColor = false;
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTableNumber.Location = new System.Drawing.Point(126, 141);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(98, 38);
            this.lblTableNumber.TabIndex = 0;
            this.lblTableNumber.Text = "TABLE";
            // 
            // btnTable10
            // 
            this.btnTable10.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTable10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTable10.Location = new System.Drawing.Point(252, 453);
            this.btnTable10.Name = "btnTable10";
            this.btnTable10.Size = new System.Drawing.Size(79, 73);
            this.btnTable10.TabIndex = 9;
            this.btnTable10.Text = "10";
            this.btnTable10.UseVisualStyleBackColor = false;
            this.btnTable10.Click += new System.EventHandler(this.btnTable10_Click);
            // 
            // btnTable9
            // 
            this.btnTable9.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTable9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTable9.Location = new System.Drawing.Point(82, 453);
            this.btnTable9.Name = "btnTable9";
            this.btnTable9.Size = new System.Drawing.Size(79, 73);
            this.btnTable9.TabIndex = 8;
            this.btnTable9.Text = "9";
            this.btnTable9.UseVisualStyleBackColor = false;
            this.btnTable9.Click += new System.EventHandler(this.btnTable9_Click);
            // 
            // btnTable8
            // 
            this.btnTable8.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTable8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTable8.Location = new System.Drawing.Point(252, 360);
            this.btnTable8.Name = "btnTable8";
            this.btnTable8.Size = new System.Drawing.Size(79, 73);
            this.btnTable8.TabIndex = 7;
            this.btnTable8.Text = "8";
            this.btnTable8.UseVisualStyleBackColor = false;
            this.btnTable8.Click += new System.EventHandler(this.btnTable8_Click);
            // 
            // btnTable7
            // 
            this.btnTable7.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTable7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTable7.Location = new System.Drawing.Point(82, 361);
            this.btnTable7.Name = "btnTable7";
            this.btnTable7.Size = new System.Drawing.Size(79, 73);
            this.btnTable7.TabIndex = 6;
            this.btnTable7.Text = "7";
            this.btnTable7.UseVisualStyleBackColor = false;
            this.btnTable7.Click += new System.EventHandler(this.btnTable7_Click);
            // 
            // btnTable6
            // 
            this.btnTable6.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTable6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTable6.Location = new System.Drawing.Point(252, 267);
            this.btnTable6.Name = "btnTable6";
            this.btnTable6.Size = new System.Drawing.Size(79, 73);
            this.btnTable6.TabIndex = 5;
            this.btnTable6.Text = "6";
            this.btnTable6.UseVisualStyleBackColor = false;
            this.btnTable6.Click += new System.EventHandler(this.btnTable6_Click);
            // 
            // btnTable5
            // 
            this.btnTable5.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTable5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTable5.Location = new System.Drawing.Point(82, 267);
            this.btnTable5.Name = "btnTable5";
            this.btnTable5.Size = new System.Drawing.Size(79, 73);
            this.btnTable5.TabIndex = 4;
            this.btnTable5.Text = "5";
            this.btnTable5.UseVisualStyleBackColor = false;
            this.btnTable5.Click += new System.EventHandler(this.btnTable5_Click);
            // 
            // btnTable4
            // 
            this.btnTable4.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTable4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTable4.Location = new System.Drawing.Point(252, 174);
            this.btnTable4.Name = "btnTable4";
            this.btnTable4.Size = new System.Drawing.Size(79, 73);
            this.btnTable4.TabIndex = 3;
            this.btnTable4.Text = "4";
            this.btnTable4.UseVisualStyleBackColor = false;
            this.btnTable4.Click += new System.EventHandler(this.btnTable4_Click);
            // 
            // btnTable3
            // 
            this.btnTable3.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTable3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTable3.Location = new System.Drawing.Point(82, 174);
            this.btnTable3.Name = "btnTable3";
            this.btnTable3.Size = new System.Drawing.Size(79, 73);
            this.btnTable3.TabIndex = 2;
            this.btnTable3.Text = "3";
            this.btnTable3.UseVisualStyleBackColor = false;
            this.btnTable3.Click += new System.EventHandler(this.btnTable3_Click);
            // 
            // btnTable2
            // 
            this.btnTable2.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTable2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTable2.Location = new System.Drawing.Point(252, 84);
            this.btnTable2.Name = "btnTable2";
            this.btnTable2.Size = new System.Drawing.Size(79, 73);
            this.btnTable2.TabIndex = 1;
            this.btnTable2.Text = "2";
            this.btnTable2.UseVisualStyleBackColor = false;
            this.btnTable2.Click += new System.EventHandler(this.btnTable2_Click);
            // 
            // btnTable1
            // 
            this.btnTable1.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTable1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTable1.Location = new System.Drawing.Point(82, 84);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(79, 73);
            this.btnTable1.TabIndex = 0;
            this.btnTable1.Text = "1";
            this.btnTable1.UseVisualStyleBackColor = false;
            this.btnTable1.Click += new System.EventHandler(this.btnTable1_Click);
            // 
            // tableOrderOverviewTab
            // 
            this.tableOrderOverviewTab.BackColor = System.Drawing.Color.White;
            this.tableOrderOverviewTab.Controls.Add(this.lblDisplayVAT);
            this.tableOrderOverviewTab.Controls.Add(this.lblDisplayTotal);
            this.tableOrderOverviewTab.Controls.Add(this.btnEdit);
            this.tableOrderOverviewTab.Controls.Add(this.btnRemove);
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
            // lblDisplayVAT
            // 
            this.lblDisplayVAT.AutoSize = true;
            this.lblDisplayVAT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDisplayVAT.Location = new System.Drawing.Point(345, 591);
            this.lblDisplayVAT.Name = "lblDisplayVAT";
            this.lblDisplayVAT.Size = new System.Drawing.Size(0, 28);
            this.lblDisplayVAT.TabIndex = 10;
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.AutoSize = true;
            this.lblDisplayTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDisplayTotal.Location = new System.Drawing.Point(323, 563);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(0, 28);
            this.lblDisplayTotal.TabIndex = 9;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(122, 654);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(8, 654);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.listViewTableOrder.SelectedIndexChanged += new System.EventHandler(this.listViewTableOrder_SelectedIndexChanged);
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
            this.addOrderView.Controls.Add(this.btnComment);
            this.addOrderView.Controls.Add(this.pnlComment);
            this.addOrderView.Controls.Add(this.listViewAddOrder);
            this.addOrderView.Controls.Add(this.btnAddOrder);
            this.addOrderView.Controls.Add(this.lblOrder);
            this.addOrderView.Controls.Add(this.listViewOrderSummary);
            this.addOrderView.Controls.Add(this.btnDrinksMenu);
            this.addOrderView.Controls.Add(this.btnDinnerMenu);
            this.addOrderView.Controls.Add(this.btnLunchMenu);
            this.addOrderView.Location = new System.Drawing.Point(4, 29);
            this.addOrderView.Name = "addOrderView";
            this.addOrderView.Padding = new System.Windows.Forms.Padding(3);
            this.addOrderView.Size = new System.Drawing.Size(413, 690);
            this.addOrderView.TabIndex = 3;
            this.addOrderView.Text = "AddOrderView";
            this.addOrderView.UseVisualStyleBackColor = true;
            // 
            // btnComment
            // 
            this.btnComment.Location = new System.Drawing.Point(8, 649);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(94, 29);
            this.btnComment.TabIndex = 11;
            this.btnComment.Text = "Comment";
            this.btnComment.UseVisualStyleBackColor = true;
            // 
            // pnlComment
            // 
            this.pnlComment.Controls.Add(this.btnAddComment);
            this.pnlComment.Controls.Add(this.txtboxComment);
            this.pnlComment.Location = new System.Drawing.Point(99, 489);
            this.pnlComment.Name = "pnlComment";
            this.pnlComment.Size = new System.Drawing.Size(250, 125);
            this.pnlComment.TabIndex = 10;
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(85, 85);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(94, 29);
            this.btnAddComment.TabIndex = 1;
            this.btnAddComment.Text = "Add";
            this.btnAddComment.UseVisualStyleBackColor = true;
            // 
            // txtboxComment
            // 
            this.txtboxComment.Location = new System.Drawing.Point(85, 51);
            this.txtboxComment.Name = "txtboxComment";
            this.txtboxComment.Size = new System.Drawing.Size(125, 27);
            this.txtboxComment.TabIndex = 0;
            this.txtboxComment.Text = "Comment...";
            // 
            // listViewAddOrder
            // 
            this.listViewAddOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPrice});
            this.listViewAddOrder.HideSelection = false;
            this.listViewAddOrder.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listViewAddOrder.Location = new System.Drawing.Point(7, 62);
            this.listViewAddOrder.Name = "listViewAddOrder";
            this.listViewAddOrder.Size = new System.Drawing.Size(400, 346);
            this.listViewAddOrder.TabIndex = 9;
            this.listViewAddOrder.UseCompatibleStateImageBehavior = false;
            this.listViewAddOrder.View = System.Windows.Forms.View.Details;
            this.listViewAddOrder.SelectedIndexChanged += new System.EventHandler(this.listViewAddOrder_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "Product Name";
            this.chName.Width = 350;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            this.chPrice.Width = 50;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddOrder.Location = new System.Drawing.Point(301, 646);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(106, 38);
            this.btnAddOrder.TabIndex = 8;
            this.btnAddOrder.Text = "ADD";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
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
            this.listViewOrderSummary.View = System.Windows.Forms.View.Details;
            // 
            // CHCount
            // 
            this.CHCount.Text = "Count";
            this.CHCount.Width = 50;
            // 
            // CHItemname
            // 
            this.CHItemname.Text = "Name";
            this.CHItemname.Width = 350;
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
            this.btnDrinksMenu.Click += new System.EventHandler(this.btnDrinksMenu_Click);
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
            this.btnDinnerMenu.Click += new System.EventHandler(this.btnDinnerMenu_Click);
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
            this.btnLunchMenu.Click += new System.EventHandler(this.btnLunchMenu_Click);
            // 
            // tabPagePayment
            // 
            this.tabPagePayment.Controls.Add(this.btn_payment);
            this.tabPagePayment.Controls.Add(this.lbl_vat_amount);
            this.tabPagePayment.Controls.Add(this.lbl_VAT);
            this.tabPagePayment.Controls.Add(this.lbl_price1);
            this.tabPagePayment.Controls.Add(this.lbl_price2);
            this.tabPagePayment.Controls.Add(this.label1);
            this.tabPagePayment.Controls.Add(this.btn_VISA);
            this.tabPagePayment.Controls.Add(this.btn_DEBIT);
            this.tabPagePayment.Controls.Add(this.lbl_crditCardType);
            this.tabPagePayment.Controls.Add(this.lbl_total);
            this.tabPagePayment.Controls.Add(this.lbl_contents);
            this.tabPagePayment.Controls.Add(this.lbl_bill);
            this.tabPagePayment.Location = new System.Drawing.Point(4, 29);
            this.tabPagePayment.Name = "tabPagePayment";
            this.tabPagePayment.Size = new System.Drawing.Size(413, 690);
            this.tabPagePayment.TabIndex = 6;
            this.tabPagePayment.Text = "Payment";
            this.tabPagePayment.UseVisualStyleBackColor = true;
            // 
            // btn_payment
            // 
            this.btn_payment.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_payment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_payment.Location = new System.Drawing.Point(14, 587);
            this.btn_payment.Margin = new System.Windows.Forms.Padding(2);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(377, 43);
            this.btn_payment.TabIndex = 13;
            this.btn_payment.Text = "PROCEED TO PAYMENT";
            this.btn_payment.UseVisualStyleBackColor = false;
            // 
            // lbl_vat_amount
            // 
            this.lbl_vat_amount.AutoSize = true;
            this.lbl_vat_amount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_vat_amount.Location = new System.Drawing.Point(301, 534);
            this.lbl_vat_amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_vat_amount.Name = "lbl_vat_amount";
            this.lbl_vat_amount.Size = new System.Drawing.Size(98, 23);
            this.lbl_vat_amount.TabIndex = 12;
            this.lbl_vat_amount.Text = "vat amount";
            // 
            // lbl_VAT
            // 
            this.lbl_VAT.AutoSize = true;
            this.lbl_VAT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_VAT.Location = new System.Drawing.Point(14, 534);
            this.lbl_VAT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_VAT.Name = "lbl_VAT";
            this.lbl_VAT.Size = new System.Drawing.Size(43, 23);
            this.lbl_VAT.TabIndex = 11;
            this.lbl_VAT.Text = "VAT:";
            // 
            // lbl_price1
            // 
            this.lbl_price1.AutoSize = true;
            this.lbl_price1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_price1.Location = new System.Drawing.Point(346, 314);
            this.lbl_price1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_price1.Name = "lbl_price1";
            this.lbl_price1.Size = new System.Drawing.Size(47, 23);
            this.lbl_price1.TabIndex = 10;
            this.lbl_price1.Text = "price";
            // 
            // lbl_price2
            // 
            this.lbl_price2.AutoSize = true;
            this.lbl_price2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_price2.Location = new System.Drawing.Point(346, 498);
            this.lbl_price2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_price2.Name = "lbl_price2";
            this.lbl_price2.Size = new System.Drawing.Size(47, 23);
            this.lbl_price2.TabIndex = 9;
            this.lbl_price2.Text = "price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 498);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "ORDER PRICE:";
            // 
            // btn_VISA
            // 
            this.btn_VISA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VISA.Location = new System.Drawing.Point(262, 414);
            this.btn_VISA.Margin = new System.Windows.Forms.Padding(2);
            this.btn_VISA.Name = "btn_VISA";
            this.btn_VISA.Size = new System.Drawing.Size(128, 27);
            this.btn_VISA.TabIndex = 7;
            this.btn_VISA.Text = "VISA/AMEX";
            this.btn_VISA.UseVisualStyleBackColor = true;
            // 
            // btn_DEBIT
            // 
            this.btn_DEBIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DEBIT.Location = new System.Drawing.Point(14, 414);
            this.btn_DEBIT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DEBIT.Name = "btn_DEBIT";
            this.btn_DEBIT.Size = new System.Drawing.Size(128, 27);
            this.btn_DEBIT.TabIndex = 6;
            this.btn_DEBIT.Text = "DEBIT";
            this.btn_DEBIT.UseVisualStyleBackColor = true;
            // 
            // lbl_crditCardType
            // 
            this.lbl_crditCardType.AutoSize = true;
            this.lbl_crditCardType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_crditCardType.Location = new System.Drawing.Point(14, 368);
            this.lbl_crditCardType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_crditCardType.Name = "lbl_crditCardType";
            this.lbl_crditCardType.Size = new System.Drawing.Size(233, 23);
            this.lbl_crditCardType.TabIndex = 5;
            this.lbl_crditCardType.Text = "CHOOSE CREDIT CARD TYPE:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_total.Location = new System.Drawing.Point(14, 314);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(72, 23);
            this.lbl_total.TabIndex = 3;
            this.lbl_total.Text = "TOTAL:";
            // 
            // lbl_contents
            // 
            this.lbl_contents.AutoSize = true;
            this.lbl_contents.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_contents.Location = new System.Drawing.Point(14, 164);
            this.lbl_contents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_contents.Name = "lbl_contents";
            this.lbl_contents.Size = new System.Drawing.Size(125, 23);
            this.lbl_contents.TabIndex = 1;
            this.lbl_contents.Text = "Order contents";
            this.lbl_contents.Click += new System.EventHandler(this.lbl_contents_Click);
            // 
            // lbl_bill
            // 
            this.lbl_bill.AutoSize = true;
            this.lbl_bill.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_bill.Location = new System.Drawing.Point(6, 10);
            this.lbl_bill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bill.Name = "lbl_bill";
            this.lbl_bill.Size = new System.Drawing.Size(87, 46);
            this.lbl_bill.TabIndex = 0;
            this.lbl_bill.Text = "BILL";
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 29);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(413, 690);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "TableView";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeName
            // 
            this.btnEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEmployeeName.Location = new System.Drawing.Point(319, 12);
            this.btnEmployeeName.Name = "btnEmployeeName";
            this.btnEmployeeName.Size = new System.Drawing.Size(94, 29);
            this.btnEmployeeName.TabIndex = 1;
            this.btnEmployeeName.UseVisualStyleBackColor = false;
            this.btnEmployeeName.Click += new System.EventHandler(this.btnEmployeeName_Click);
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
            this.tableNumber.Click += new System.EventHandler(this.tableNumber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.PaleGreen;
            this.label2.Location = new System.Drawing.Point(101, 619);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(191, 619);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(284, 619);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "M";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(82, 654);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "   FREE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(173, 654);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "OCCUPIED";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(262, 654);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "RESERVED";
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
            this.tableViewTab.ResumeLayout(false);
            this.tableViewTab.PerformLayout();
            this.pnlTableStatus.ResumeLayout(false);
            this.pnlTableStatus.PerformLayout();
            this.tableOrderOverviewTab.ResumeLayout(false);
            this.tableOrderOverviewTab.PerformLayout();
            this.addOrderView.ResumeLayout(false);
            this.addOrderView.PerformLayout();
            this.pnlComment.ResumeLayout(false);
            this.pnlComment.PerformLayout();
            this.tabPagePayment.ResumeLayout(false);
            this.tabPagePayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tableViewTab;
        private System.Windows.Forms.TabPage tableOrderOverviewTab;
        private System.Windows.Forms.TabPage addOrderView;
        private System.Windows.Forms.Button btnEmployeeName;
        private System.Windows.Forms.TabPage tabPagePayment;
        private System.Windows.Forms.TabPage tabPage8;
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
        private System.Windows.Forms.Button btnDrinksMenu;
        private System.Windows.Forms.Button btnDinnerMenu;
        private System.Windows.Forms.Button btnLunchMenu;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ListView listViewOrderSummary;
        private System.Windows.Forms.ColumnHeader CHCount;
        private System.Windows.Forms.ColumnHeader CHItemname;
        private System.Windows.Forms.Label lbl_bill;
        private System.Windows.Forms.Label lbl_vat_amount;
        private System.Windows.Forms.Label lbl_VAT;
        private System.Windows.Forms.Label lbl_price1;
        private System.Windows.Forms.Label lbl_price2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_VISA;
        private System.Windows.Forms.Button btn_DEBIT;
        private System.Windows.Forms.Label lbl_crditCardType;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_contents;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btnTable10;
        private System.Windows.Forms.Button btnTable9;
        private System.Windows.Forms.Button btnTable8;
        private System.Windows.Forms.Button btnTable7;
        private System.Windows.Forms.Button btnTable6;
        private System.Windows.Forms.Button btnTable5;
        private System.Windows.Forms.Button btnTable4;
        private System.Windows.Forms.Button btnTable3;
        private System.Windows.Forms.Button btnTable2;
        private System.Windows.Forms.Button btnTable1;
        private System.Windows.Forms.Panel pnlTableStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGoToTable;
        private System.Windows.Forms.RadioButton RBreserved;
        private System.Windows.Forms.RadioButton RBoccupied;
        private System.Windows.Forms.RadioButton RBfree;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.ListView listViewAddOrder;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblDisplayTotal;
        private System.Windows.Forms.Label lblDisplayVAT;
        private System.Windows.Forms.Panel pnlComment;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.TextBox txtboxComment;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}