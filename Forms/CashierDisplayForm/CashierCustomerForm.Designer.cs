namespace OOADPRO.Forms.CashierDisplayForm
{
    partial class CashierCustomerForm
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
            labelOverview = new Label();
            dataGridViewCustomer = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            SuspendLayout();
            // 
            // labelOverview
            // 
            labelOverview.AutoSize = true;
            labelOverview.Font = new Font("Sitka Small Semibold", 14F, FontStyle.Bold);
            labelOverview.Location = new Point(42, 98);
            labelOverview.Name = "labelOverview";
            labelOverview.Size = new Size(105, 28);
            labelOverview.TabIndex = 12;
            labelOverview.Text = "UserData";
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Location = new Point(51, 191);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.Size = new Size(963, 344);
            dataGridViewCustomer.TabIndex = 13;
            dataGridViewCustomer.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CashierCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 802);
            Controls.Add(dataGridViewCustomer);
            Controls.Add(labelOverview);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierCustomerForm";
            Text = "OverviewForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOverview;
        private DataGridView dataGridViewCustomer;
    }
}