﻿namespace OOADPRO.Forms
{
    partial class CashierForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnOrder = new Button();
            btnLogout = new Button();
            btnCustomer = new Button();
            btnCashierProducts = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panelcontrolMain = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 57, 91);
            panel1.Controls.Add(btnOrder);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnCustomer);
            panel1.Controls.Add(btnCashierProducts);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 802);
            panel1.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(38, 57, 91);
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = Color.FromArgb(212, 203, 229);

            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(32, 287);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(234, 38);
            btnOrder.TabIndex = 8;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(38, 57, 91);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(212, 203, 229);
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(32, 738);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(234, 38);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.FromArgb(38, 57, 91);
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.FromArgb(212, 203, 229);

            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(32, 213);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(234, 38);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnCashierProducts
            // 
            btnCashierProducts.BackColor = Color.FromArgb(38, 57, 91);
            btnCashierProducts.Cursor = Cursors.Hand;
            btnCashierProducts.FlatAppearance.BorderSize = 0;
            btnCashierProducts.FlatStyle = FlatStyle.Flat;
            btnCashierProducts.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashierProducts.ForeColor = Color.FromArgb(212, 203, 229);

            btnCashierProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnCashierProducts.Location = new Point(32, 138);
            btnCashierProducts.Name = "btnCashierProducts";
            btnCashierProducts.Size = new Size(234, 38);
            btnCashierProducts.TabIndex = 1;
            btnCashierProducts.Text = "Products";
            btnCashierProducts.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 57, 91);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 100);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(38, 57, 91);
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(212, 203, 229);
            label1.Location = new Point(62, 36);
            label1.Name = "label1";
            label1.Size = new Size(164, 35);
            label1.TabIndex = 0;
            label1.Text = "Coffee Shop";
            // 
            // panelcontrolMain
            // 
            panelcontrolMain.BackColor = Color.FromArgb(243, 244, 243);
            panelcontrolMain.Location = new Point(289, -1);
            panelcontrolMain.Name = "panelcontrolMain";
            panelcontrolMain.Size = new Size(1092, 802);
            panelcontrolMain.TabIndex = 1;
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 800);
            Controls.Add(panelcontrolMain);
            Controls.Add(panel1);
            Name = "CashierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cashier";
            Load += CashierForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panelcontrolMain;
        private Button btnCashierProducts;
        private Label label1;
        private Button btnOverview;
        private Button btnLogout;
        private Button btnSale;
        private Button btnCategory;
        private Button btnUser;
        private Button btnCustomer;
        private Button btnOrder;
    }
}