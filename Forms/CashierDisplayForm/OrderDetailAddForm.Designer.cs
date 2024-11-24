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
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            txtTotal = new Label();
            dataGridView1 = new DataGridView();
            SR = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            txtProductName = new TextBox();
            labelOverview = new Label();
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(708, 435);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(84, 29);
            textBox1.TabIndex = 85;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(626, 480);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 82;
            label2.Text = "Charge";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(620, 435);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 81;
            label1.Text = "Amount";
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(930, 439);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SR, Qty, Amount, Product });
            dataGridView1.Location = new Point(626, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(404, 412);
            dataGridView1.TabIndex = 79;
            // 
            // SR
            // 
            SR.HeaderText = "SR";
            SR.Name = "SR";
            SR.ReadOnly = true;
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.Name = "Product";
            Product.ReadOnly = true;
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
            // OrderDetailAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 724);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label1;
        private Label txtTotal;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SR;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Product;
        private TextBox txtProductName;
        private Label labelOverview;
    }
}