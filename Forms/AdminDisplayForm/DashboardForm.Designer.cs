namespace OOADPRO.Forms.AdminDisplayForm
{
    partial class DashboardForm
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
            labelDashboard = new Label();
            formsPlot1 = new ScottPlot.FormsPlot();
            SuspendLayout();
            // 
            // labelDashboard
            // 
            labelDashboard.AutoSize = true;
            labelDashboard.Location = new Point(255, 50);
            labelDashboard.Name = "labelDashboard";
            labelDashboard.Size = new Size(64, 15);
            labelDashboard.TabIndex = 0;
            labelDashboard.Text = "Dashboard";
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(109, 92);
            formsPlot1.Margin = new Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(450, 286);
            formsPlot1.TabIndex = 1;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 802);
            Controls.Add(formsPlot1);
            Controls.Add(labelDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDashboard;
        private ScottPlot.FormsPlot formsPlot1;
    }
}