﻿namespace OOADPRO.Forms.CashierDisplayForm
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            btnAddStaff = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAddStaff
            // 
            btnAddStaff.FlatStyle = FlatStyle.Flat;
            btnAddStaff.ForeColor = Color.FromArgb(243, 244, 243);
            btnAddStaff.Image = (Image)resources.GetObject("btnAddStaff.Image");
            btnAddStaff.Location = new Point(34, 44);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(49, 46);
            btnAddStaff.TabIndex = 2;
            btnAddStaff.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1030, 150);
            dataGridView1.TabIndex = 3;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 763);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddStaff);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderForm";
            Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddStaff;
        private DataGridView dataGridView1;
    }
}