namespace OrderingSystemUI
{
    partial class BarmanUI
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
            this.lbl_Orders = new System.Windows.Forms.Label();
            this.listViewOrdersBarView = new System.Windows.Forms.ListView();
            this.Initialized = new System.Windows.Forms.Button();
            this.InProgress = new System.Windows.Forms.Button();
            this.Completed = new System.Windows.Forms.Button();
            this.lblChangeOrderStatus = new System.Windows.Forms.Label();
            this.lbl_OrdersDisplay = new System.Windows.Forms.Label();
            this.lblOrderStatusDisplay = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblViewOrderStatus = new System.Windows.Forms.Label();
            this.listViewBarOrderStatus = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbl_Orders
            // 
            this.lbl_Orders.AutoSize = true;
            this.lbl_Orders.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_Orders.Location = new System.Drawing.Point(612, 28);
            this.lbl_Orders.Name = "lbl_Orders";
            this.lbl_Orders.Size = new System.Drawing.Size(96, 25);
            this.lbl_Orders.TabIndex = 1;
            this.lbl_Orders.Text = "Bar Orders";
            // 
            // listViewOrdersBarView
            // 
            this.listViewOrdersBarView.HideSelection = false;
            this.listViewOrdersBarView.Location = new System.Drawing.Point(12, 100);
            this.listViewOrdersBarView.Name = "listViewOrdersBarView";
            this.listViewOrdersBarView.Size = new System.Drawing.Size(835, 373);
            this.listViewOrdersBarView.TabIndex = 2;
            this.listViewOrdersBarView.UseCompatibleStateImageBehavior = false;
            // 
            // Initialized
            // 
            this.Initialized.Location = new System.Drawing.Point(853, 153);
            this.Initialized.Name = "Initialized";
            this.Initialized.Size = new System.Drawing.Size(112, 34);
            this.Initialized.TabIndex = 4;
            this.Initialized.Text = "Initialized";
            this.Initialized.UseVisualStyleBackColor = true;
            this.Initialized.Click += new System.EventHandler(this.Initialized_Click);
            // 
            // InProgress
            // 
            this.InProgress.BackColor = System.Drawing.Color.DarkOrange;
            this.InProgress.Location = new System.Drawing.Point(983, 153);
            this.InProgress.Name = "InProgress";
            this.InProgress.Size = new System.Drawing.Size(112, 34);
            this.InProgress.TabIndex = 5;
            this.InProgress.Text = "In progress";
            this.InProgress.UseVisualStyleBackColor = false;
            // 
            // Completed
            // 
            this.Completed.BackColor = System.Drawing.Color.LightGreen;
            this.Completed.Location = new System.Drawing.Point(1111, 153);
            this.Completed.Name = "Completed";
            this.Completed.Size = new System.Drawing.Size(112, 34);
            this.Completed.TabIndex = 6;
            this.Completed.Text = "Completed";
            this.Completed.UseVisualStyleBackColor = false;
            // 
            // lblChangeOrderStatus
            // 
            this.lblChangeOrderStatus.AutoSize = true;
            this.lblChangeOrderStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblChangeOrderStatus.Location = new System.Drawing.Point(969, 114);
            this.lblChangeOrderStatus.Name = "lblChangeOrderStatus";
            this.lblChangeOrderStatus.Size = new System.Drawing.Size(172, 25);
            this.lblChangeOrderStatus.TabIndex = 7;
            this.lblChangeOrderStatus.Text = "Change order status";
            // 
            // lbl_OrdersDisplay
            // 
            this.lbl_OrdersDisplay.AutoSize = true;
            this.lbl_OrdersDisplay.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_OrdersDisplay.Location = new System.Drawing.Point(16, 9);
            this.lbl_OrdersDisplay.MinimumSize = new System.Drawing.Size(1210, 70);
            this.lbl_OrdersDisplay.Name = "lbl_OrdersDisplay";
            this.lbl_OrdersDisplay.Size = new System.Drawing.Size(1210, 70);
            this.lbl_OrdersDisplay.TabIndex = 8;
            // 
            // lblOrderStatusDisplay
            // 
            this.lblOrderStatusDisplay.AutoSize = true;
            this.lblOrderStatusDisplay.BackColor = System.Drawing.Color.DarkOrange;
            this.lblOrderStatusDisplay.Location = new System.Drawing.Point(853, 100);
            this.lblOrderStatusDisplay.MinimumSize = new System.Drawing.Size(370, 50);
            this.lblOrderStatusDisplay.Name = "lblOrderStatusDisplay";
            this.lblOrderStatusDisplay.Size = new System.Drawing.Size(370, 50);
            this.lblOrderStatusDisplay.TabIndex = 9;
            this.lblOrderStatusDisplay.Click += new System.EventHandler(this.lbl_OrderStatusDisplay_Click);
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblOrderStatus.Location = new System.Drawing.Point(853, 190);
            this.lblOrderStatus.MinimumSize = new System.Drawing.Size(370, 50);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(370, 50);
            this.lblOrderStatus.TabIndex = 13;
            // 
            // lblViewOrderStatus
            // 
            this.lblViewOrderStatus.AutoSize = true;
            this.lblViewOrderStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblViewOrderStatus.Location = new System.Drawing.Point(969, 202);
            this.lblViewOrderStatus.Name = "lblViewOrderStatus";
            this.lblViewOrderStatus.Size = new System.Drawing.Size(149, 25);
            this.lblViewOrderStatus.TabIndex = 14;
            this.lblViewOrderStatus.Text = "View order status";
            // 
            // listViewBarOrderStatus
            // 
            this.listViewBarOrderStatus.HideSelection = false;
            this.listViewBarOrderStatus.Location = new System.Drawing.Point(853, 243);
            this.listViewBarOrderStatus.Name = "listViewBarOrderStatus";
            this.listViewBarOrderStatus.Size = new System.Drawing.Size(373, 129);
            this.listViewBarOrderStatus.TabIndex = 15;
            this.listViewBarOrderStatus.UseCompatibleStateImageBehavior = false;
            // 
            // BarmanUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 495);
            this.Controls.Add(this.listViewBarOrderStatus);
            this.Controls.Add(this.lblViewOrderStatus);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.lblChangeOrderStatus);
            this.Controls.Add(this.Completed);
            this.Controls.Add(this.InProgress);
            this.Controls.Add(this.Initialized);
            this.Controls.Add(this.listViewOrdersBarView);
            this.Controls.Add(this.lbl_Orders);
            this.Controls.Add(this.lbl_OrdersDisplay);
            this.Controls.Add(this.lblOrderStatusDisplay);
            this.Name = "BarmanUI";
            this.Text = "BarmanUI";
            this.Load += new System.EventHandler(this.BarmanUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Orders;
        private System.Windows.Forms.ListView listViewOrdersBarView;
        private System.Windows.Forms.Button Initialized;
        private System.Windows.Forms.Button InProgress;
        private System.Windows.Forms.Button Completed;
        private System.Windows.Forms.Label lblChangeOrderStatus;
        private System.Windows.Forms.Label lbl_OrdersDisplay;
        private System.Windows.Forms.Label lblOrderStatusDisplay;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label lblViewOrderStatus;
        private System.Windows.Forms.ListView listViewBarOrderStatus;
    }
}