﻿namespace OOADPRO.Forms.AdminDisplayForm
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
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
            btnAddStaff.Location = new Point(46, 34);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(49, 46);
            btnAddStaff.TabIndex = 1;
            btnAddStaff.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1021, 150);
            dataGridView1.TabIndex = 2;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 243);
            ClientSize = new Size(1092, 802);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddStaff);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffForm";
            Text = "StaffForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddStaff;
        private DataGridView dataGridView1;
    }
}