namespace OrderingSystemUI
{
    partial class BartenderAndChefUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BartenderAndChefUI));
            this.lbl_Orders = new System.Windows.Forms.Label();
            this.lblChangeOrderStatus = new System.Windows.Forms.Label();
            this.btnInitialized = new System.Windows.Forms.Button();
            this.btnInProgress = new System.Windows.Forms.Button();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.lbl_OrdersDisplay = new System.Windows.Forms.Label();
            this.lblOrderStatusDisplay = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblViewOrderStatus = new System.Windows.Forms.Label();
            this.listViewOrdersStatus = new System.Windows.Forms.ListView();
            this.lblComment = new System.Windows.Forms.Label();
            this.panelChefUI = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelChefUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Orders
            // 
            this.lbl_Orders.AutoSize = true;
            this.lbl_Orders.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_Orders.Location = new System.Drawing.Point(653, 91);
            this.lbl_Orders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Orders.Name = "lbl_Orders";
            this.lbl_Orders.Size = new System.Drawing.Size(71, 25);
            this.lbl_Orders.TabIndex = 4;
            this.lbl_Orders.Text = " Orders";
            // 
            // lblChangeOrderStatus
            // 
            this.lblChangeOrderStatus.AutoSize = true;
            this.lblChangeOrderStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblChangeOrderStatus.Location = new System.Drawing.Point(992, 172);
            this.lblChangeOrderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeOrderStatus.Name = "lblChangeOrderStatus";
            this.lblChangeOrderStatus.Size = new System.Drawing.Size(172, 25);
            this.lblChangeOrderStatus.TabIndex = 5;
            this.lblChangeOrderStatus.Text = "Change order status";
            // 
            // btnInitialized
            // 
            this.btnInitialized.Location = new System.Drawing.Point(924, 213);
            this.btnInitialized.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnInProgress.Location = new System.Drawing.Point(1100, 213);
            this.btnInProgress.Margin = new System.Windows.Forms.Padding(2);
            this.btnInProgress.Name = "btnInProgress";
            this.btnInProgress.Size = new System.Drawing.Size(112, 34);
            this.btnInProgress.TabIndex = 7;
            this.btnInProgress.Text = "Prepared";
            this.btnInProgress.UseVisualStyleBackColor = false;
            this.btnInProgress.Click += new System.EventHandler(this.btnInProgress_Click);
            // 
            // listViewOrders
            // 
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(2, 160);
            this.listViewOrders.Margin = new System.Windows.Forms.Padding(2);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(835, 468);
            this.listViewOrders.TabIndex = 9;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.SelectedIndexChanged += new System.EventHandler(this.listViewOrdersKitchenView_SelectedIndexChanged);
            // 
            // lbl_OrdersDisplay
            // 
            this.lbl_OrdersDisplay.AutoSize = true;
            this.lbl_OrdersDisplay.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_OrdersDisplay.Location = new System.Drawing.Point(2, 68);
            this.lbl_OrdersDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_OrdersDisplay.MinimumSize = new System.Drawing.Size(1293, 70);
            this.lbl_OrdersDisplay.Name = "lbl_OrdersDisplay";
            this.lbl_OrdersDisplay.Size = new System.Drawing.Size(1293, 70);
            this.lbl_OrdersDisplay.TabIndex = 10;
            // 
            // lblOrderStatusDisplay
            // 
            this.lblOrderStatusDisplay.AutoSize = true;
            this.lblOrderStatusDisplay.BackColor = System.Drawing.Color.DarkOrange;
            this.lblOrderStatusDisplay.Location = new System.Drawing.Point(836, 161);
            this.lblOrderStatusDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderStatusDisplay.MinimumSize = new System.Drawing.Size(462, 50);
            this.lblOrderStatusDisplay.Name = "lblOrderStatusDisplay";
            this.lblOrderStatusDisplay.Size = new System.Drawing.Size(462, 50);
            this.lblOrderStatusDisplay.TabIndex = 11;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblOrderStatus.Location = new System.Drawing.Point(836, 249);
            this.lblOrderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderStatus.MinimumSize = new System.Drawing.Size(462, 50);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(462, 50);
            this.lblOrderStatus.TabIndex = 12;
            // 
            // lblViewOrderStatus
            // 
            this.lblViewOrderStatus.AutoSize = true;
            this.lblViewOrderStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblViewOrderStatus.Location = new System.Drawing.Point(1006, 261);
            this.lblViewOrderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewOrderStatus.Name = "lblViewOrderStatus";
            this.lblViewOrderStatus.Size = new System.Drawing.Size(149, 25);
            this.lblViewOrderStatus.TabIndex = 13;
            this.lblViewOrderStatus.Text = "View order status";
            // 
            // listViewOrdersStatus
            // 
            this.listViewOrdersStatus.HideSelection = false;
            this.listViewOrdersStatus.Location = new System.Drawing.Point(836, 301);
            this.listViewOrdersStatus.Margin = new System.Windows.Forms.Padding(2);
            this.listViewOrdersStatus.MinimumSize = new System.Drawing.Size(462, 4);
            this.listViewOrdersStatus.Name = "listViewOrdersStatus";
            this.listViewOrdersStatus.Size = new System.Drawing.Size(462, 132);
            this.listViewOrdersStatus.TabIndex = 14;
            this.listViewOrdersStatus.UseCompatibleStateImageBehavior = false;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComment.Location = new System.Drawing.Point(836, 435);
            this.lblComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComment.MinimumSize = new System.Drawing.Size(462, 105);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(462, 105);
            this.lblComment.TabIndex = 15;
            // 
            // panelChefUI
            // 
            this.panelChefUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChefUI.Controls.Add(this.lbl_Orders);
            this.panelChefUI.Controls.Add(this.lblComment);
            this.panelChefUI.Controls.Add(this.lbl_OrdersDisplay);
            this.panelChefUI.Controls.Add(this.btnRefresh);
            this.panelChefUI.Controls.Add(this.listViewOrdersStatus);
            this.panelChefUI.Controls.Add(this.btnEmployee);
            this.panelChefUI.Controls.Add(this.lblViewOrderStatus);
            this.panelChefUI.Controls.Add(this.lblChangeOrderStatus);
            this.panelChefUI.Controls.Add(this.pictureBox3);
            this.panelChefUI.Controls.Add(this.lblOrderStatusDisplay);
            this.panelChefUI.Controls.Add(this.listViewOrders);
            this.panelChefUI.Controls.Add(this.btnInitialized);
            this.panelChefUI.Controls.Add(this.btnInProgress);
            this.panelChefUI.Controls.Add(this.lblOrderStatus);
            this.panelChefUI.Location = new System.Drawing.Point(10, 16);
            this.panelChefUI.Margin = new System.Windows.Forms.Padding(2);
            this.panelChefUI.Name = "panelChefUI";
            this.panelChefUI.Size = new System.Drawing.Size(1299, 629);
            this.panelChefUI.TabIndex = 18;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightGray;
            this.btnRefresh.Font = new System.Drawing.Font("Broadway", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(773, 161);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 62);
            this.btnRefresh.TabIndex = 41;
            this.btnRefresh.Text = "↻";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEmployee.Location = new System.Drawing.Point(1166, 17);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(112, 34);
            this.btnEmployee.TabIndex = 10;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 60);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // BartenderAndChefUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 649);
            this.Controls.Add(this.panelChefUI);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "BartenderAndChefUI";
            this.Text = "BartenderAndChefUI";
            this.Load += new System.EventHandler(this.BartenderAndChefUI_Load);
            this.panelChefUI.ResumeLayout(false);
            this.panelChefUI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Orders;
        private System.Windows.Forms.Label lblChangeOrderStatus;
        private System.Windows.Forms.Button btnInitialized;
        private System.Windows.Forms.Button btnInProgress;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.Label lbl_OrdersDisplay;
        private System.Windows.Forms.Label lblOrderStatusDisplay;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label lblViewOrderStatus;
        private System.Windows.Forms.ListView listViewOrdersStatus;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Panel panelChefUI;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnRefresh;
    }
}