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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_OrdersDisplay = new System.Windows.Forms.Label();
            this.lbl_OrderStatusDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Orders
            // 
            this.lbl_Orders.AutoSize = true;
            this.lbl_Orders.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(853, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Initialized";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(984, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "In progress";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1111, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "Completed";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(995, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Order status";
            // 
            // lbl_OrdersDisplay
            // 
            this.lbl_OrdersDisplay.AutoSize = true;
            this.lbl_OrdersDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_OrdersDisplay.Location = new System.Drawing.Point(16, 9);
            this.lbl_OrdersDisplay.MinimumSize = new System.Drawing.Size(1210, 70);
            this.lbl_OrdersDisplay.Name = "lbl_OrdersDisplay";
            this.lbl_OrdersDisplay.Size = new System.Drawing.Size(1210, 70);
            this.lbl_OrdersDisplay.TabIndex = 8;
            // 
            // lbl_OrderStatusDisplay
            // 
            this.lbl_OrderStatusDisplay.AutoSize = true;
            this.lbl_OrderStatusDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_OrderStatusDisplay.Location = new System.Drawing.Point(853, 100);
            this.lbl_OrderStatusDisplay.MinimumSize = new System.Drawing.Size(370, 50);
            this.lbl_OrderStatusDisplay.Name = "lbl_OrderStatusDisplay";
            this.lbl_OrderStatusDisplay.Size = new System.Drawing.Size(370, 50);
            this.lbl_OrderStatusDisplay.TabIndex = 9;
            this.lbl_OrderStatusDisplay.Click += new System.EventHandler(this.lbl_OrderStatusDisplay_Click);
            // 
            // BarmanUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewOrdersBarView);
            this.Controls.Add(this.lbl_Orders);
            this.Controls.Add(this.lbl_OrdersDisplay);
            this.Controls.Add(this.lbl_OrderStatusDisplay);
            this.Name = "BarmanUI";
            this.Text = "BarmanUI";
            this.Load += new System.EventHandler(this.BarmanUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Orders;
        private System.Windows.Forms.ListView listViewOrdersBarView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_OrdersDisplay;
        private System.Windows.Forms.Label lbl_OrderStatusDisplay;
    }
}