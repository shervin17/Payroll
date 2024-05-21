namespace PayrollV1
{
    partial class EmployeePageForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageDTRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeInTimeOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDTRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payslipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyForLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_label = new System.Windows.Forms.Label();
            this.log_outBTN = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDTRToolStripMenuItem,
            this.payslipToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.applyForLeaveToolStripMenuItem,
            this.editProfileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1446, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageDTRToolStripMenuItem
            // 
            this.manageDTRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeInTimeOutToolStripMenuItem,
            this.viewDTRToolStripMenuItem});
            this.manageDTRToolStripMenuItem.Name = "manageDTRToolStripMenuItem";
            this.manageDTRToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.manageDTRToolStripMenuItem.Text = "Manage DTR";
            // 
            // timeInTimeOutToolStripMenuItem
            // 
            this.timeInTimeOutToolStripMenuItem.Name = "timeInTimeOutToolStripMenuItem";
            this.timeInTimeOutToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.timeInTimeOutToolStripMenuItem.Text = "Time in Time out";
            this.timeInTimeOutToolStripMenuItem.Click += new System.EventHandler(this.timeInTimeOutToolStripMenuItem_Click);
            // 
            // viewDTRToolStripMenuItem
            // 
            this.viewDTRToolStripMenuItem.Name = "viewDTRToolStripMenuItem";
            this.viewDTRToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.viewDTRToolStripMenuItem.Text = "View DTR";
            // 
            // payslipToolStripMenuItem
            // 
            this.payslipToolStripMenuItem.Name = "payslipToolStripMenuItem";
            this.payslipToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.payslipToolStripMenuItem.Text = "Payslip";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // applyForLeaveToolStripMenuItem
            // 
            this.applyForLeaveToolStripMenuItem.Name = "applyForLeaveToolStripMenuItem";
            this.applyForLeaveToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.applyForLeaveToolStripMenuItem.Text = "Apply for Leave";
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.editProfileToolStripMenuItem.Text = "Edit Profile";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1421, 691);
            this.panel1.TabIndex = 1;
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Location = new System.Drawing.Point(899, 10);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(45, 16);
            this.user_label.TabIndex = 2;
            this.user_label.Text = "Hello, ";
            // 
            // log_outBTN
            // 
            this.log_outBTN.Location = new System.Drawing.Point(1325, 3);
            this.log_outBTN.Name = "log_outBTN";
            this.log_outBTN.Size = new System.Drawing.Size(75, 23);
            this.log_outBTN.TabIndex = 3;
            this.log_outBTN.Text = "logout";
            this.log_outBTN.UseVisualStyleBackColor = true;
            this.log_outBTN.Click += new System.EventHandler(this.log_outBTN_Click);
            // 
            // EmployeePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 735);
            this.Controls.Add(this.log_outBTN);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeePageForm";
            this.Text = "EmployeePageForm";
            this.Load += new System.EventHandler(this.EmployeePageForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageDTRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payslipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeInTimeOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDTRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyForLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Button log_outBTN;
    }
}