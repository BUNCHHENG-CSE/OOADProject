namespace OOADPRO.Forms.AdminDisplayForm
{
    partial class SaleReportForm
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
            formsPlotDailySale = new ScottPlot.FormsPlot();
            formsPlotMonthlySale = new ScottPlot.FormsPlot();
            formsPlotYearlySale = new ScottPlot.FormsPlot();
            formsPlotOverallIncome = new ScottPlot.FormsPlot();
            labelDailySale = new Label();
            labelMonthlySale = new Label();
            labelYearlySale = new Label();
            labelOverallIncome = new Label();
            SuspendLayout();
            // 
            // formsPlotDailySale
            // 
            formsPlotDailySale.Location = new Point(56, 61);
            formsPlotDailySale.Margin = new Padding(4, 3, 4, 3);
            formsPlotDailySale.Name = "formsPlotDailySale";
            formsPlotDailySale.Size = new Size(450, 286);
            formsPlotDailySale.TabIndex = 7;
            // 
            // formsPlotMonthlySale
            // 
            formsPlotMonthlySale.Location = new Point(595, 61);
            formsPlotMonthlySale.Margin = new Padding(4, 3, 4, 3);
            formsPlotMonthlySale.Name = "formsPlotMonthlySale";
            formsPlotMonthlySale.Size = new Size(450, 286);
            formsPlotMonthlySale.TabIndex = 8;
            // 
            // formsPlotYearlySale
            // 
            formsPlotYearlySale.Location = new Point(46, 436);
            formsPlotYearlySale.Margin = new Padding(4, 3, 4, 3);
            formsPlotYearlySale.Name = "formsPlotYearlySale";
            formsPlotYearlySale.Size = new Size(450, 286);
            formsPlotYearlySale.TabIndex = 9;
            // 
            // formsPlotOverallIncome
            // 
            formsPlotOverallIncome.Location = new Point(595, 436);
            formsPlotOverallIncome.Margin = new Padding(4, 3, 4, 3);
            formsPlotOverallIncome.Name = "formsPlotOverallIncome";
            formsPlotOverallIncome.Size = new Size(450, 286);
            formsPlotOverallIncome.TabIndex = 10;
            // 
            // labelDailySale
            // 
            labelDailySale.AutoSize = true;
            labelDailySale.Font = new Font("Sitka Small Semibold", 14F, FontStyle.Bold);
            labelDailySale.Location = new Point(215, 43);
            labelDailySale.Name = "labelDailySale";
            labelDailySale.Size = new Size(113, 28);
            labelDailySale.TabIndex = 11;
            labelDailySale.Text = "Daily Sale";
            // 
            // labelMonthlySale
            // 
            labelMonthlySale.AutoSize = true;
            labelMonthlySale.Font = new Font("Sitka Small Semibold", 14F, FontStyle.Bold);
            labelMonthlySale.Location = new Point(788, 43);
            labelMonthlySale.Name = "labelMonthlySale";
            labelMonthlySale.Size = new Size(144, 28);
            labelMonthlySale.TabIndex = 12;
            labelMonthlySale.Text = "Monthly Sale";
            // 
            // labelYearlySale
            // 
            labelYearlySale.AutoSize = true;
            labelYearlySale.Font = new Font("Sitka Small Semibold", 14F, FontStyle.Bold);
            labelYearlySale.Location = new Point(203, 405);
            labelYearlySale.Name = "labelYearlySale";
            labelYearlySale.Size = new Size(114, 28);
            labelYearlySale.TabIndex = 13;
            labelYearlySale.Text = "Yealy Sale";
            // 
            // labelOverallIncome
            // 
            labelOverallIncome.AutoSize = true;
            labelOverallIncome.Font = new Font("Sitka Small Semibold", 14F, FontStyle.Bold);
            labelOverallIncome.Location = new Point(762, 405);
            labelOverallIncome.Name = "labelOverallIncome";
            labelOverallIncome.Size = new Size(170, 28);
            labelOverallIncome.TabIndex = 14;
            labelOverallIncome.Text = "Overall  Income";
            // 
            // SaleReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 802);
            Controls.Add(labelOverallIncome);
            Controls.Add(labelYearlySale);
            Controls.Add(labelMonthlySale);
            Controls.Add(labelDailySale);
            Controls.Add(formsPlotOverallIncome);
            Controls.Add(formsPlotYearlySale);
            Controls.Add(formsPlotMonthlySale);
            Controls.Add(formsPlotDailySale);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SaleReportForm";
            Text = "SaleReportForm";
            Load += SaleReportForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.FormsPlot formsPlotDailySale;
        private ScottPlot.FormsPlot formsPlotMonthlySale;
        private ScottPlot.FormsPlot formsPlotYearlySale;
        private ScottPlot.FormsPlot formsPlotOverallIncome;
        private Label labelDailySale;
        private Label labelMonthlySale;
        private Label labelYearlySale;
        private Label labelOverallIncome;
    }
}