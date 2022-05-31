
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
            this.txt_Orders = new System.Windows.Forms.TextBox();
            this.lbl_Orders = new System.Windows.Forms.Label();
            this.listBox_Orders_KitchenView = new System.Windows.Forms.ListBox();
            this.lbl_orderStatus = new System.Windows.Forms.Label();
            this.btn_Initialized = new System.Windows.Forms.Button();
            this.btn_inProgress = new System.Windows.Forms.Button();
            this.btn_Completed = new System.Windows.Forms.Button();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Orders
            // 
            this.txt_Orders.Location = new System.Drawing.Point(13, 13);
            this.txt_Orders.MaximumSize = new System.Drawing.Size(200, 50);
            this.txt_Orders.MinimumSize = new System.Drawing.Size(770, 70);
            this.txt_Orders.Name = "txt_Orders";
            this.txt_Orders.Size = new System.Drawing.Size(770, 70);
            this.txt_Orders.TabIndex = 0;
            // 
            // lbl_Orders
            // 
            this.lbl_Orders.AutoSize = true;
            this.lbl_Orders.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Orders.Location = new System.Drawing.Point(350, 32);
            this.lbl_Orders.Name = "lbl_Orders";
            this.lbl_Orders.Size = new System.Drawing.Size(66, 25);
            this.lbl_Orders.TabIndex = 1;
            this.lbl_Orders.Text = "Orders";
            // 
            // listBox_Orders_KitchenView
            // 
            this.listBox_Orders_KitchenView.FormattingEnabled = true;
            this.listBox_Orders_KitchenView.ItemHeight = 25;
            this.listBox_Orders_KitchenView.Location = new System.Drawing.Point(13, 119);
            this.listBox_Orders_KitchenView.Name = "listBox_Orders_KitchenView";
            this.listBox_Orders_KitchenView.Size = new System.Drawing.Size(393, 279);
            this.listBox_Orders_KitchenView.TabIndex = 2;
            // 
            // lbl_orderStatus
            // 
            this.lbl_orderStatus.AutoSize = true;
            this.lbl_orderStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_orderStatus.Location = new System.Drawing.Point(542, 131);
            this.lbl_orderStatus.Name = "lbl_orderStatus";
            this.lbl_orderStatus.Size = new System.Drawing.Size(110, 25);
            this.lbl_orderStatus.TabIndex = 4;
            this.lbl_orderStatus.Text = "Order status";
            // 
            // btn_Initialized
            // 
            this.btn_Initialized.Location = new System.Drawing.Point(413, 176);
            this.btn_Initialized.Name = "btn_Initialized";
            this.btn_Initialized.Size = new System.Drawing.Size(112, 34);
            this.btn_Initialized.TabIndex = 5;
            this.btn_Initialized.Text = "Initialized";
            this.btn_Initialized.UseVisualStyleBackColor = true;
            // 
            // btn_inProgress
            // 
            this.btn_inProgress.Location = new System.Drawing.Point(531, 176);
            this.btn_inProgress.Name = "btn_inProgress";
            this.btn_inProgress.Size = new System.Drawing.Size(112, 34);
            this.btn_inProgress.TabIndex = 6;
            this.btn_inProgress.Text = "In progress";
            this.btn_inProgress.UseVisualStyleBackColor = true;
            // 
            // btn_Completed
            // 
            this.btn_Completed.Location = new System.Drawing.Point(649, 176);
            this.btn_Completed.Name = "btn_Completed";
            this.btn_Completed.Size = new System.Drawing.Size(112, 34);
            this.btn_Completed.TabIndex = 7;
            this.btn_Completed.Text = "Completed";
            this.btn_Completed.UseVisualStyleBackColor = true;
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(412, 119);
            this.txt_Status.MinimumSize = new System.Drawing.Size(350, 50);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(350, 50);
            this.txt_Status.TabIndex = 8;
            // 
            // WaiterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.btn_Completed);
            this.Controls.Add(this.btn_inProgress);
            this.Controls.Add(this.btn_Initialized);
            this.Controls.Add(this.lbl_orderStatus);
            this.Controls.Add(this.listBox_Orders_KitchenView);
            this.Controls.Add(this.lbl_Orders);
            this.Controls.Add(this.txt_Orders);
            this.Controls.Add(this.txt_Status);
            this.Name = "WaiterUI";
            this.Text = "ChefUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Orders;
        private System.Windows.Forms.Label lbl_Orders;
        private System.Windows.Forms.ListBox listBox_Orders_KitchenView;
        private System.Windows.Forms.Label lbl_orderStatus;
        private System.Windows.Forms.Button btn_Initialized;
        private System.Windows.Forms.Button btn_inProgress;
        private System.Windows.Forms.Button btn_Completed;
        private System.Windows.Forms.TextBox txt_Status;
    }
}