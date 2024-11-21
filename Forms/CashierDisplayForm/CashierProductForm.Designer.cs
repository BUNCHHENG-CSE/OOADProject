namespace OOADPRO.Forms.CashierDisplayForm
{
    partial class CashierProductForm
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
            txtProductName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            txtProductName.Location = new Point(136, 21);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(243, 28);
            txtProductName.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(36, 20);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 69;
            label1.Text = "Search :";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 802);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductForm";
            Text = "OverviewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductName;
        private Label label1;
    }
}