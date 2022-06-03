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
            this.txt_Orders = new System.Windows.Forms.TextBox();
            this.lbl_Orders = new System.Windows.Forms.Label();
            this.listViewBarViewOrders = new System.Windows.Forms.ListView();
            this.txt_OrderStatus = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Orders
            // 
            this.txt_Orders.Location = new System.Drawing.Point(12, 12);
            this.txt_Orders.MaximumSize = new System.Drawing.Size(770, 70);
            this.txt_Orders.MinimumSize = new System.Drawing.Size(770, 70);
            this.txt_Orders.Name = "txt_Orders";
            this.txt_Orders.Size = new System.Drawing.Size(770, 70);
            this.txt_Orders.TabIndex = 0;
            // 
            // lbl_Orders
            // 
            this.lbl_Orders.AutoSize = true;
            this.lbl_Orders.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Orders.Location = new System.Drawing.Point(381, 31);
            this.lbl_Orders.Name = "lbl_Orders";
            this.lbl_Orders.Size = new System.Drawing.Size(66, 25);
            this.lbl_Orders.TabIndex = 1;
            this.lbl_Orders.Text = "Orders";
            // 
            // listViewBarViewOrders
            // 
            this.listViewBarViewOrders.HideSelection = false;
            this.listViewBarViewOrders.Location = new System.Drawing.Point(16, 100);
            this.listViewBarViewOrders.Name = "listViewBarViewOrders";
            this.listViewBarViewOrders.Size = new System.Drawing.Size(410, 326);
            this.listViewBarViewOrders.TabIndex = 2;
            this.listViewBarViewOrders.UseCompatibleStateImageBehavior = false;
            // 
            // txt_OrderStatus
            // 
            this.txt_OrderStatus.Location = new System.Drawing.Point(432, 100);
            this.txt_OrderStatus.MinimumSize = new System.Drawing.Size(350, 50);
            this.txt_OrderStatus.Name = "txt_OrderStatus";
            this.txt_OrderStatus.Size = new System.Drawing.Size(350, 50);
            this.txt_OrderStatus.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Initialized";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "In progress";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(668, 162);
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
            this.label1.Location = new System.Drawing.Point(554, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Order status";
            // 
            // BarmanUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_OrderStatus);
            this.Controls.Add(this.listViewBarViewOrders);
            this.Controls.Add(this.lbl_Orders);
            this.Controls.Add(this.txt_Orders);
            this.Name = "BarmanUI";
            this.Text = "BarmanUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Orders;
        private System.Windows.Forms.Label lbl_Orders;
        private System.Windows.Forms.ListView listViewBarViewOrders;
        private System.Windows.Forms.TextBox txt_OrderStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}