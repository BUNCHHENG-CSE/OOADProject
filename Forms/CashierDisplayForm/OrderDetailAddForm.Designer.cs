namespace OOADPRO.Forms.CashierDisplayForm
{
    partial class OrderDetailAddForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            txtTotal = new Label();
            dataGridView1 = new DataGridView();
            txtProductName = new TextBox();
            labelOverview = new Label();
            OrderDetailID = new DataGridViewTextBoxColumn();
            ProductsID = new DataGridViewTextBoxColumn();
            ProductsName = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(18, 48);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(555, 643);
            flowLayoutPanel1.TabIndex = 86;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(626, 582);
            button1.Name = "button1";
            button1.Size = new Size(92, 42);
            button1.TabIndex = 83;
            button1.Text = "Pay Order";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(862, 463);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(52, 25);
            txtTotal.TabIndex = 80;
            txtTotal.Text = "Total";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderDetailID, ProductsID, ProductsName, Qty, UnitPrice, Amount });
            dataGridView1.Location = new Point(604, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(434, 412);
            dataGridView1.TabIndex = 79;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            txtProductName.Location = new Point(118, 3);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(211, 28);
            txtProductName.TabIndex = 78;
            // 
            // labelOverview
            // 
            labelOverview.AutoSize = true;
            labelOverview.Font = new Font("Sitka Small Semibold", 14F, FontStyle.Bold);
            labelOverview.Location = new Point(18, 2);
            labelOverview.Name = "labelOverview";
            labelOverview.Size = new Size(94, 28);
            labelOverview.TabIndex = 77;
            labelOverview.Text = "Search :";
            // 
            // OrderDetailID
            // 
            OrderDetailID.HeaderText = "SR";
            OrderDetailID.Name = "OrderDetailID";
            OrderDetailID.ReadOnly = true;
            OrderDetailID.Width = 30;
            // 
            // ProductsID
            // 
            ProductsID.HeaderText = "ID";
            ProductsID.Name = "ProductsID";
            ProductsID.ReadOnly = true;
            ProductsID.Width = 30;
            // 
            // ProductsName
            // 
            ProductsName.HeaderText = "Product";
            ProductsName.Name = "ProductsName";
            ProductsName.ReadOnly = true;
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            Qty.Width = 30;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "Unit Price";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.HeaderText = "Total";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // OrderDetailAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 724);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(txtTotal);
            Controls.Add(dataGridView1);
            Controls.Add(txtProductName);
            Controls.Add(labelOverview);
            Name = "OrderDetailAddForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Label txtTotal;
        private DataGridView dataGridView1;
        private TextBox txtProductName;
        private Label labelOverview;
        private DataGridViewTextBoxColumn OrderDetailID;
        private DataGridViewTextBoxColumn ProductsID;
        private DataGridViewTextBoxColumn ProductsName;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Amount;
    }
}