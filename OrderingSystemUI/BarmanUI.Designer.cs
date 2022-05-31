
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Initialized = new System.Windows.Forms.Button();
            this.btn_inProgress = new System.Windows.Forms.Button();
            this.btn_Completed = new System.Windows.Forms.Button();
            this.txt_Orders = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Orders
            // 
            this.lbl_Orders.AutoSize = true;
            this.lbl_Orders.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Orders.Location = new System.Drawing.Point(365, 49);
            this.lbl_Orders.Name = "lbl_Orders";
            this.lbl_Orders.Size = new System.Drawing.Size(66, 25);
            this.lbl_Orders.TabIndex = 1;
            this.lbl_Orders.Text = "Orders";
            // 
            // listViewOrdersBarView
            // 
            this.listViewOrdersBarView.HideSelection = false;
            this.listViewOrdersBarView.Location = new System.Drawing.Point(18, 118);
            this.listViewOrdersBarView.Name = "listViewOrdersBarView";
            this.listViewOrdersBarView.Size = new System.Drawing.Size(413, 311);
            this.listViewOrdersBarView.TabIndex = 2;
            this.listViewOrdersBarView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(555, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order status";
            // 
            // btn_Initialized
            // 
            this.btn_Initialized.Location = new System.Drawing.Point(437, 174);
            this.btn_Initialized.Name = "btn_Initialized";
            this.btn_Initialized.Size = new System.Drawing.Size(112, 34);
            this.btn_Initialized.TabIndex = 6;
            this.btn_Initialized.Text = "Initialized";
            this.btn_Initialized.UseVisualStyleBackColor = true;
            // 
            // btn_inProgress
            // 
            this.btn_inProgress.Location = new System.Drawing.Point(555, 174);
            this.btn_inProgress.Name = "btn_inProgress";
            this.btn_inProgress.Size = new System.Drawing.Size(112, 34);
            this.btn_inProgress.TabIndex = 7;
            this.btn_inProgress.Text = "In progress";
            this.btn_inProgress.UseVisualStyleBackColor = true;
            // 
            // btn_Completed
            // 
            this.btn_Completed.Location = new System.Drawing.Point(673, 174);
            this.btn_Completed.Name = "btn_Completed";
            this.btn_Completed.Size = new System.Drawing.Size(112, 34);
            this.btn_Completed.TabIndex = 8;
            this.btn_Completed.Text = "Completed";
            this.btn_Completed.UseVisualStyleBackColor = true;
            // 
            // txt_Orders
            // 
            this.txt_Orders.Location = new System.Drawing.Point(18, 28);
            this.txt_Orders.MaximumSize = new System.Drawing.Size(200, 50);
            this.txt_Orders.MinimumSize = new System.Drawing.Size(770, 70);
            this.txt_Orders.Name = "txt_Orders";
            this.txt_Orders.Size = new System.Drawing.Size(770, 70);
            this.txt_Orders.TabIndex = 9;
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(435, 118);
            this.txt_Status.MinimumSize = new System.Drawing.Size(350, 50);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(350, 31);
            this.txt_Status.TabIndex = 14;
            // 
            // BarmanUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Completed);
            this.Controls.Add(this.btn_inProgress);
            this.Controls.Add(this.btn_Initialized);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewOrdersBarView);
            this.Controls.Add(this.lbl_Orders);
            this.Controls.Add(this.txt_Orders);
            this.Controls.Add(this.txt_Status);
            this.Name = "BarmanUI";
            this.Text = "BarmanUI";
            this.Load += new System.EventHandler(this.BarmanUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Orders;
        private System.Windows.Forms.ListView listViewOrdersBarView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Initialized;
        private System.Windows.Forms.Button btn_inProgress;
        private System.Windows.Forms.Button btn_Completed;
        private System.Windows.Forms.TextBox txt_Orders;
        private System.Windows.Forms.TextBox txt_Status;
    }
}