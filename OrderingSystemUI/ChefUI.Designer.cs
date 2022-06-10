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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefUI));
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
            this.lblComment = new System.Windows.Forms.Label();
            this.panelChefUI = new System.Windows.Forms.Panel();
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
            this.lbl_Orders.Location = new System.Drawing.Point(616, 107);
            this.lbl_Orders.Name = "lbl_Orders";
            this.lbl_Orders.Size = new System.Drawing.Size(128, 25);
            this.lbl_Orders.TabIndex = 4;
            this.lbl_Orders.Text = "Kitchen Orders";
            // 
            // lblChangeOrderStatus
            // 
            this.lblChangeOrderStatus.AutoSize = true;
            this.lblChangeOrderStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblChangeOrderStatus.Location = new System.Drawing.Point(973, 192);
            this.lblChangeOrderStatus.Name = "lblChangeOrderStatus";
            this.lblChangeOrderStatus.Size = new System.Drawing.Size(172, 25);
            this.lblChangeOrderStatus.TabIndex = 5;
            this.lblChangeOrderStatus.Text = "Change order status";
            // 
            // btnInitialized
            // 
            this.btnInitialized.Location = new System.Drawing.Point(852, 231);
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
            this.btnInProgress.Location = new System.Drawing.Point(982, 231);
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
            this.btnCompleted.Location = new System.Drawing.Point(1110, 231);
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
            this.listViewOrdersKitchenView.Location = new System.Drawing.Point(3, 160);
            this.listViewOrdersKitchenView.Name = "listViewOrdersKitchenView";
            this.listViewOrdersKitchenView.Size = new System.Drawing.Size(834, 381);
            this.listViewOrdersKitchenView.TabIndex = 9;
            this.listViewOrdersKitchenView.UseCompatibleStateImageBehavior = false;
            this.listViewOrdersKitchenView.SelectedIndexChanged += new System.EventHandler(this.listViewOrdersKitchenView_SelectedIndexChanged);
            // 
            // lbl_OrdersDisplay
            // 
            this.lbl_OrdersDisplay.AutoSize = true;
            this.lbl_OrdersDisplay.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_OrdersDisplay.Location = new System.Drawing.Point(12, 85);
            this.lbl_OrdersDisplay.MinimumSize = new System.Drawing.Size(1210, 70);
            this.lbl_OrdersDisplay.Name = "lbl_OrdersDisplay";
            this.lbl_OrdersDisplay.Size = new System.Drawing.Size(1210, 70);
            this.lbl_OrdersDisplay.TabIndex = 10;
            // 
            // lblOrderStatusDisplay
            // 
            this.lblOrderStatusDisplay.AutoSize = true;
            this.lblOrderStatusDisplay.BackColor = System.Drawing.Color.DarkOrange;
            this.lblOrderStatusDisplay.Location = new System.Drawing.Point(852, 178);
            this.lblOrderStatusDisplay.MinimumSize = new System.Drawing.Size(370, 50);
            this.lblOrderStatusDisplay.Name = "lblOrderStatusDisplay";
            this.lblOrderStatusDisplay.Size = new System.Drawing.Size(370, 50);
            this.lblOrderStatusDisplay.TabIndex = 11;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblOrderStatus.Location = new System.Drawing.Point(852, 272);
            this.lblOrderStatus.MinimumSize = new System.Drawing.Size(370, 50);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(370, 50);
            this.lblOrderStatus.TabIndex = 12;
            // 
            // lblViewOrderStatus
            // 
            this.lblViewOrderStatus.AutoSize = true;
            this.lblViewOrderStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblViewOrderStatus.Location = new System.Drawing.Point(982, 283);
            this.lblViewOrderStatus.Name = "lblViewOrderStatus";
            this.lblViewOrderStatus.Size = new System.Drawing.Size(149, 25);
            this.lblViewOrderStatus.TabIndex = 13;
            this.lblViewOrderStatus.Text = "View order status";
            // 
            // listViewKitchenOrderStatus
            // 
            this.listViewKitchenOrderStatus.HideSelection = false;
            this.listViewKitchenOrderStatus.Location = new System.Drawing.Point(851, 329);
            this.listViewKitchenOrderStatus.Name = "listViewKitchenOrderStatus";
            this.listViewKitchenOrderStatus.Size = new System.Drawing.Size(371, 131);
            this.listViewKitchenOrderStatus.TabIndex = 14;
            this.listViewKitchenOrderStatus.UseCompatibleStateImageBehavior = false;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComment.Location = new System.Drawing.Point(852, 463);
            this.lblComment.MinimumSize = new System.Drawing.Size(370, 70);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(370, 70);
            this.lblComment.TabIndex = 15;
            // 
            // panelChefUI
            // 
            this.panelChefUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChefUI.Controls.Add(this.btnEmployee);
            this.panelChefUI.Controls.Add(this.pictureBox3);
            this.panelChefUI.Controls.Add(this.listViewOrdersKitchenView);
            this.panelChefUI.Location = new System.Drawing.Point(10, 16);
            this.panelChefUI.Name = "panelChefUI";
            this.panelChefUI.Size = new System.Drawing.Size(1214, 543);
            this.panelChefUI.TabIndex = 18;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEmployee.Location = new System.Drawing.Point(1087, 19);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(112, 34);
            this.btnEmployee.TabIndex = 10;
            this.btnEmployee.Text = "Mara";
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
            // ChefUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 570);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.listViewKitchenOrderStatus);
            this.Controls.Add(this.lblViewOrderStatus);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnInProgress);
            this.Controls.Add(this.btnInitialized);
            this.Controls.Add(this.lblChangeOrderStatus);
            this.Controls.Add(this.lbl_Orders);
            this.Controls.Add(this.lbl_OrdersDisplay);
            this.Controls.Add(this.lblOrderStatusDisplay);
            this.Controls.Add(this.panelChefUI);
            this.Name = "ChefUI";
            this.Text = "ChefUI";
            this.Load += new System.EventHandler(this.ChefUI_Load);
            this.panelChefUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Panel panelChefUI;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnEmployee;
    }
}