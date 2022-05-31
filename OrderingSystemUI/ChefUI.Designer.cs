
namespace OrderingSystemUI
{
    partial class chefUI
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
            this.listViewOrdersKitchenView = new System.Windows.Forms.ListView();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Initialized = new System.Windows.Forms.Button();
            this.btn_inProgress = new System.Windows.Forms.Button();
            this.btn_Completed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Orders
            // 
            this.txt_Orders.Location = new System.Drawing.Point(18, 23);
            this.txt_Orders.MaximumSize = new System.Drawing.Size(200, 50);
            this.txt_Orders.MinimumSize = new System.Drawing.Size(770, 70);
            this.txt_Orders.Name = "txt_Orders";
            this.txt_Orders.Size = new System.Drawing.Size(770, 70);
            this.txt_Orders.TabIndex = 10;
            // 
            // lbl_Orders
            // 
            this.lbl_Orders.AutoSize = true;
            this.lbl_Orders.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Orders.Location = new System.Drawing.Point(388, 44);
            this.lbl_Orders.Name = "lbl_Orders";
            this.lbl_Orders.Size = new System.Drawing.Size(66, 25);
            this.lbl_Orders.TabIndex = 11;
            this.lbl_Orders.Text = "Orders";
            // 
            // listViewOrdersKitchenView
            // 
            this.listViewOrdersKitchenView.HideSelection = false;
            this.listViewOrdersKitchenView.Location = new System.Drawing.Point(18, 114);
            this.listViewOrdersKitchenView.Name = "listViewOrdersKitchenView";
            this.listViewOrdersKitchenView.Size = new System.Drawing.Size(413, 311);
            this.listViewOrdersKitchenView.TabIndex = 12;
            this.listViewOrdersKitchenView.UseCompatibleStateImageBehavior = false;
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(437, 114);
            this.txt_Status.MinimumSize = new System.Drawing.Size(350, 50);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(350, 50);
            this.txt_Status.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(558, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Order status";
            // 
            // btn_Initialized
            // 
            this.btn_Initialized.Location = new System.Drawing.Point(438, 170);
            this.btn_Initialized.Name = "btn_Initialized";
            this.btn_Initialized.Size = new System.Drawing.Size(112, 34);
            this.btn_Initialized.TabIndex = 15;
            this.btn_Initialized.Text = "Initialized";
            this.btn_Initialized.UseVisualStyleBackColor = true;
            // 
            // btn_inProgress
            // 
            this.btn_inProgress.Location = new System.Drawing.Point(556, 170);
            this.btn_inProgress.Name = "btn_inProgress";
            this.btn_inProgress.Size = new System.Drawing.Size(112, 34);
            this.btn_inProgress.TabIndex = 16;
            this.btn_inProgress.Text = "In progress";
            this.btn_inProgress.UseVisualStyleBackColor = true;
            // 
            // btn_Completed
            // 
            this.btn_Completed.Location = new System.Drawing.Point(676, 170);
            this.btn_Completed.Name = "btn_Completed";
            this.btn_Completed.Size = new System.Drawing.Size(112, 34);
            this.btn_Completed.TabIndex = 17;
            this.btn_Completed.Text = "Completed";
            this.btn_Completed.UseVisualStyleBackColor = true;
            // 
            // chefUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Completed);
            this.Controls.Add(this.btn_inProgress);
            this.Controls.Add(this.btn_Initialized);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.listViewOrdersKitchenView);
            this.Controls.Add(this.lbl_Orders);
            this.Controls.Add(this.txt_Orders);
            this.Name = "chefUI";
            this.Text = "chefUI";
            this.Load += new System.EventHandler(this.chefUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Orders;
        private System.Windows.Forms.Label lbl_Orders;
        private System.Windows.Forms.ListView listViewOrdersKitchenView;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Initialized;
        private System.Windows.Forms.Button btn_inProgress;
        private System.Windows.Forms.Button btn_Completed;
    }
}