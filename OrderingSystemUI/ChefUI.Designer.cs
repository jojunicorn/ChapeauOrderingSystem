namespace OrderingSystemUI
{
    partial class ChefUI
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
            this.lblChangeOrderStatus = new System.Windows.Forms.Label();
            this.btnInitialized = new System.Windows.Forms.Button();
            this.btnInProgress = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.listViewOrdersKitchenView = new System.Windows.Forms.ListView();
            this.lbl_OrdersDisplay = new System.Windows.Forms.Label();
            this.lblOrderStatusDisplay = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblViewOrderStatus = new System.Windows.Forms.Label();
            this.listViewKitchenOrderStatus = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbl_Orders
            // 
            this.lbl_Orders.AutoSize = true;
            this.lbl_Orders.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_Orders.Location = new System.Drawing.Point(616, 31);
            this.lbl_Orders.Name = "lbl_Orders";
            this.lbl_Orders.Size = new System.Drawing.Size(128, 25);
            this.lbl_Orders.TabIndex = 4;
            this.lbl_Orders.Text = "Kitchen Orders";
            // 
            // lblChangeOrderStatus
            // 
            this.lblChangeOrderStatus.AutoSize = true;
            this.lblChangeOrderStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblChangeOrderStatus.Location = new System.Drawing.Point(973, 116);
            this.lblChangeOrderStatus.Name = "lblChangeOrderStatus";
            this.lblChangeOrderStatus.Size = new System.Drawing.Size(172, 25);
            this.lblChangeOrderStatus.TabIndex = 5;
            this.lblChangeOrderStatus.Text = "Change order status";
            // 
            // btnInitialized
            // 
            this.btnInitialized.Location = new System.Drawing.Point(852, 155);
            this.btnInitialized.Name = "btnInitialized";
            this.btnInitialized.Size = new System.Drawing.Size(112, 34);
            this.btnInitialized.TabIndex = 6;
            this.btnInitialized.Text = "Initialized";
            this.btnInitialized.UseVisualStyleBackColor = true;
            this.btnInitialized.Click += new System.EventHandler(this.btnInitialized_Click);
            // 
            // btnInProgress
            // 
            this.btnInProgress.BackColor = System.Drawing.Color.DarkOrange;
            this.btnInProgress.Location = new System.Drawing.Point(982, 155);
            this.btnInProgress.Name = "btnInProgress";
            this.btnInProgress.Size = new System.Drawing.Size(112, 34);
            this.btnInProgress.TabIndex = 7;
            this.btnInProgress.Text = "Prepared";
            this.btnInProgress.UseVisualStyleBackColor = false;
            this.btnInProgress.Click += new System.EventHandler(this.btnInProgress_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.LightGreen;
            this.btnCompleted.Location = new System.Drawing.Point(1110, 155);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(112, 34);
            this.btnCompleted.TabIndex = 8;
            this.btnCompleted.Text = "Served";
            this.btnCompleted.UseVisualStyleBackColor = false;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // listViewOrdersKitchenView
            // 
            this.listViewOrdersKitchenView.HideSelection = false;
            this.listViewOrdersKitchenView.Location = new System.Drawing.Point(12, 102);
            this.listViewOrdersKitchenView.Name = "listViewOrdersKitchenView";
            this.listViewOrdersKitchenView.Size = new System.Drawing.Size(834, 381);
            this.listViewOrdersKitchenView.TabIndex = 9;
            this.listViewOrdersKitchenView.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_OrdersDisplay
            // 
            this.lbl_OrdersDisplay.AutoSize = true;
            this.lbl_OrdersDisplay.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_OrdersDisplay.Location = new System.Drawing.Point(12, 9);
            this.lbl_OrdersDisplay.MinimumSize = new System.Drawing.Size(1210, 70);
            this.lbl_OrdersDisplay.Name = "lbl_OrdersDisplay";
            this.lbl_OrdersDisplay.Size = new System.Drawing.Size(1210, 70);
            this.lbl_OrdersDisplay.TabIndex = 10;
            // 
            // lblOrderStatusDisplay
            // 
            this.lblOrderStatusDisplay.AutoSize = true;
            this.lblOrderStatusDisplay.BackColor = System.Drawing.Color.DarkOrange;
            this.lblOrderStatusDisplay.Location = new System.Drawing.Point(852, 102);
            this.lblOrderStatusDisplay.MinimumSize = new System.Drawing.Size(370, 50);
            this.lblOrderStatusDisplay.Name = "lblOrderStatusDisplay";
            this.lblOrderStatusDisplay.Size = new System.Drawing.Size(370, 50);
            this.lblOrderStatusDisplay.TabIndex = 11;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblOrderStatus.Location = new System.Drawing.Point(852, 196);
            this.lblOrderStatus.MinimumSize = new System.Drawing.Size(370, 50);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(370, 50);
            this.lblOrderStatus.TabIndex = 12;
            // 
            // lblViewOrderStatus
            // 
            this.lblViewOrderStatus.AutoSize = true;
            this.lblViewOrderStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblViewOrderStatus.Location = new System.Drawing.Point(982, 207);
            this.lblViewOrderStatus.Name = "lblViewOrderStatus";
            this.lblViewOrderStatus.Size = new System.Drawing.Size(149, 25);
            this.lblViewOrderStatus.TabIndex = 13;
            this.lblViewOrderStatus.Text = "View order status";
            // 
            // listViewKitchenOrderStatus
            // 
            this.listViewKitchenOrderStatus.HideSelection = false;
            this.listViewKitchenOrderStatus.Location = new System.Drawing.Point(851, 253);
            this.listViewKitchenOrderStatus.Name = "listViewKitchenOrderStatus";
            this.listViewKitchenOrderStatus.Size = new System.Drawing.Size(371, 131);
            this.listViewKitchenOrderStatus.TabIndex = 14;
            this.listViewKitchenOrderStatus.UseCompatibleStateImageBehavior = false;
            // 
            // ChefUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 495);
            this.Controls.Add(this.listViewKitchenOrderStatus);
            this.Controls.Add(this.lblViewOrderStatus);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.listViewOrdersKitchenView);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnInProgress);
            this.Controls.Add(this.btnInitialized);
            this.Controls.Add(this.lblChangeOrderStatus);
            this.Controls.Add(this.lbl_Orders);
            this.Controls.Add(this.lbl_OrdersDisplay);
            this.Controls.Add(this.lblOrderStatusDisplay);
            this.Name = "ChefUI";
            this.Text = "ChefUI";
            this.Load += new System.EventHandler(this.ChefUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Orders;
        private System.Windows.Forms.Label lblChangeOrderStatus;
        private System.Windows.Forms.Button btnInitialized;
        private System.Windows.Forms.Button btnInProgress;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.ListView listViewOrdersKitchenView;
        private System.Windows.Forms.Label lbl_OrdersDisplay;
        private System.Windows.Forms.Label lblOrderStatusDisplay;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label lblViewOrderStatus;
        private System.Windows.Forms.ListView listViewKitchenOrderStatus;
    }
}