namespace OOADPRO.Forms.AdminDisplayForm
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
            panel1 = new Panel();
            picStaff = new PictureBox();
            labelStaffID = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStaff).BeginInit();
            SuspendLayout();
            // 
            // btnAddStaff
            // 
            btnAddStaff.FlatStyle = FlatStyle.Flat;
            btnAddStaff.ForeColor = Color.FromArgb(243, 244, 243);
            btnAddStaff.Image = (Image)resources.GetObject("btnAddStaff.Image");
            btnAddStaff.Location = new Point(36, 36);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(49, 46);
            btnAddStaff.TabIndex = 1;
            btnAddStaff.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelStaffID);
            panel1.Controls.Add(picStaff);
            panel1.Location = new Point(36, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(1044, 639);
            panel1.TabIndex = 2;
            // 
            // picStaff
            // 
            picStaff.BorderStyle = BorderStyle.FixedSingle;
            picStaff.Location = new Point(13, 13);
            picStaff.Name = "picStaff";
            picStaff.Size = new Size(119, 143);
            picStaff.TabIndex = 14;
            picStaff.TabStop = false;
            // 
            // labelStaffID
            // 
            labelStaffID.AutoSize = true;
            labelStaffID.Font = new Font("Sitka Small", 10F, FontStyle.Bold);
            labelStaffID.Location = new Point(43, 168);
            labelStaffID.Name = "labelStaffID";
            labelStaffID.Size = new Size(66, 20);
            labelStaffID.TabIndex = 15;
            labelStaffID.Text = "Staff ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 10F, FontStyle.Bold);
            label1.Location = new Point(43, 198);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 16;
            label1.Text = "Staff ID";
            // 
            // button1
            // 
            button1.Location = new Point(13, 230);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(94, 230);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 243);
            ClientSize = new Size(1092, 802);
            Controls.Add(panel1);
            Controls.Add(btnAddStaff);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffForm";
            Text = "StaffForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStaff).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddStaff;
        private Panel panel1;
        private PictureBox picStaff;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label labelStaffID;
    }
}