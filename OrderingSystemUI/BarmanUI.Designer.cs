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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarmanUI));
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
            this.lblComment = new System.Windows.Forms.Label();
            this.panelBarmanUI = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panelBarmanUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Orders
            // 
            this.lbl_Orders.AutoSize = true;
            this.lbl_Orders.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_Orders.Location = new System.Drawing.Point(612, 111);
            this.lbl_Orders.Name = "lbl_Orders";
            this.lbl_Orders.Size = new System.Drawing.Size(96, 25);
            this.lbl_Orders.TabIndex = 1;
            this.lbl_Orders.Text = "Bar Orders";
            // 
            // listViewOrdersBarView
            // 
            this.listViewOrdersBarView.HideSelection = false;
            this.listViewOrdersBarView.Location = new System.Drawing.Point(3, 169);
            this.listViewOrdersBarView.Name = "listViewOrdersBarView";
            this.listViewOrdersBarView.Size = new System.Drawing.Size(835, 373);
            this.listViewOrdersBarView.TabIndex = 2;
            this.listViewOrdersBarView.UseCompatibleStateImageBehavior = false;
            this.listViewOrdersBarView.SelectedIndexChanged += new System.EventHandler(this.listViewOrdersBarView_SelectedIndexChanged);
            // 
            // Initialized
            // 
            this.Initialized.Location = new System.Drawing.Point(853, 236);
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
            this.InProgress.Location = new System.Drawing.Point(983, 236);
            this.InProgress.Name = "InProgress";
            this.InProgress.Size = new System.Drawing.Size(112, 34);
            this.InProgress.TabIndex = 5;
            this.InProgress.Text = "Prepared";
            this.InProgress.UseVisualStyleBackColor = false;
            this.InProgress.Click += new System.EventHandler(this.InProgress_Click);
            // 
            // Completed
            // 
            this.Completed.BackColor = System.Drawing.Color.LightGreen;
            this.Completed.Location = new System.Drawing.Point(1111, 236);
            this.Completed.Name = "Completed";
            this.Completed.Size = new System.Drawing.Size(112, 34);
            this.Completed.TabIndex = 6;
            this.Completed.Text = "Served";
            this.Completed.UseVisualStyleBackColor = false;
            this.Completed.Click += new System.EventHandler(this.Completed_Click);
            // 
            // lblChangeOrderStatus
            // 
            this.lblChangeOrderStatus.AutoSize = true;
            this.lblChangeOrderStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblChangeOrderStatus.Location = new System.Drawing.Point(969, 197);
            this.lblChangeOrderStatus.Name = "lblChangeOrderStatus";
            this.lblChangeOrderStatus.Size = new System.Drawing.Size(172, 25);
            this.lblChangeOrderStatus.TabIndex = 7;
            this.lblChangeOrderStatus.Text = "Change order status";
            // 
            // lbl_OrdersDisplay
            // 
            this.lbl_OrdersDisplay.AutoSize = true;
            this.lbl_OrdersDisplay.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_OrdersDisplay.Location = new System.Drawing.Point(0, 76);
            this.lbl_OrdersDisplay.MinimumSize = new System.Drawing.Size(1210, 70);
            this.lbl_OrdersDisplay.Name = "lbl_OrdersDisplay";
            this.lbl_OrdersDisplay.Size = new System.Drawing.Size(1210, 70);
            this.lbl_OrdersDisplay.TabIndex = 8;
            // 
            // lblOrderStatusDisplay
            // 
            this.lblOrderStatusDisplay.AutoSize = true;
            this.lblOrderStatusDisplay.BackColor = System.Drawing.Color.DarkOrange;
            this.lblOrderStatusDisplay.Location = new System.Drawing.Point(853, 183);
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
            this.lblOrderStatus.Location = new System.Drawing.Point(853, 273);
            this.lblOrderStatus.MinimumSize = new System.Drawing.Size(370, 50);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(370, 50);
            this.lblOrderStatus.TabIndex = 13;
            // 
            // lblViewOrderStatus
            // 
            this.lblViewOrderStatus.AutoSize = true;
            this.lblViewOrderStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblViewOrderStatus.Location = new System.Drawing.Point(969, 285);
            this.lblViewOrderStatus.Name = "lblViewOrderStatus";
            this.lblViewOrderStatus.Size = new System.Drawing.Size(149, 25);
            this.lblViewOrderStatus.TabIndex = 14;
            this.lblViewOrderStatus.Text = "View order status";
            // 
            // listViewBarOrderStatus
            // 
            this.listViewBarOrderStatus.HideSelection = false;
            this.listViewBarOrderStatus.Location = new System.Drawing.Point(853, 326);
            this.listViewBarOrderStatus.Name = "listViewBarOrderStatus";
            this.listViewBarOrderStatus.Size = new System.Drawing.Size(373, 129);
            this.listViewBarOrderStatus.TabIndex = 15;
            this.listViewBarOrderStatus.UseCompatibleStateImageBehavior = false;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComment.Location = new System.Drawing.Point(853, 458);
            this.lblComment.MinimumSize = new System.Drawing.Size(370, 70);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(370, 70);
            this.lblComment.TabIndex = 16;
            // 
            // panelBarmanUI
            // 
            this.panelBarmanUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarmanUI.Controls.Add(this.btnEmployee);
            this.panelBarmanUI.Controls.Add(this.pictureBox3);
            this.panelBarmanUI.Controls.Add(this.lbl_OrdersDisplay);
            this.panelBarmanUI.Controls.Add(this.listViewOrdersBarView);
            this.panelBarmanUI.Location = new System.Drawing.Point(12, 13);
            this.panelBarmanUI.Name = "panelBarmanUI";
            this.panelBarmanUI.Size = new System.Drawing.Size(1214, 543);
            this.panelBarmanUI.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 60);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEmployee.Location = new System.Drawing.Point(1088, 23);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(112, 34);
            this.btnEmployee.TabIndex = 11;
            this.btnEmployee.Text = "Aisha";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // BarmanUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 568);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.listViewBarOrderStatus);
            this.Controls.Add(this.lblViewOrderStatus);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.lblChangeOrderStatus);
            this.Controls.Add(this.Completed);
            this.Controls.Add(this.InProgress);
            this.Controls.Add(this.Initialized);
            this.Controls.Add(this.lbl_Orders);
            this.Controls.Add(this.lblOrderStatusDisplay);
            this.Controls.Add(this.panelBarmanUI);
            this.Name = "BarmanUI";
            this.Text = "BarmanUI";
            this.Load += new System.EventHandler(this.BarmanUI_Load);
            this.panelBarmanUI.ResumeLayout(false);
            this.panelBarmanUI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Panel panelBarmanUI;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnEmployee;
    }
}