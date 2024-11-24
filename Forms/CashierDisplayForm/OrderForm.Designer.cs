namespace OOADPRO.Forms.CashierDisplayForm
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
            labelOverview = new Label();
            txtProductName = new TextBox();
            dataGridView1 = new DataGridView();
            SR = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            Total = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelOverview
            // 
            labelOverview.AutoSize = true;
            labelOverview.Font = new Font("Sitka Small Semibold", 14F, FontStyle.Bold);
            labelOverview.Location = new Point(24, 22);
            labelOverview.Name = "labelOverview";
            labelOverview.Size = new Size(94, 28);
            labelOverview.TabIndex = 12;
            labelOverview.Text = "Search :";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            txtProductName.Location = new Point(124, 23);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(243, 28);
            txtProductName.TabIndex = 68;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SR, Qty, Amount, Product });
            dataGridView1.Location = new Point(632, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(436, 456);
            dataGridView1.TabIndex = 69;
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
            // Total
            // 
            Total.AutoSize = true;
            Total.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Total.Location = new Point(913, 484);
            Total.Name = "Total";
            Total.Size = new Size(52, 25);
            Total.TabIndex = 70;
            Total.Text = "Total";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(632, 517);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 71;
            label1.Text = "Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(632, 566);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 72;
            label2.Text = "Charge";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(632, 653);
            button1.Name = "button1";
            button1.Size = new Size(113, 34);
            button1.TabIndex = 73;
            button1.Text = "Pay Order";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(936, 653);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 74;
            button2.Text = "Receipt";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(717, 522);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 29);
            textBox1.TabIndex = 75;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(24, 68);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(587, 687);
            flowLayoutPanel1.TabIndex = 76;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 802);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Total);
            Controls.Add(dataGridView1);
            Controls.Add(txtProductName);
            Controls.Add(labelOverview);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderForm";
            Text = "OverviewForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOverview;
        private TextBox txtProductName;
        private DataGridView dataGridView1;
        private Label Total;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn SR;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Product;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}