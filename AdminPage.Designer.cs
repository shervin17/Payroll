namespace PayrollV1
{
    partial class AdminPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEmployeeRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAndUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateLoginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAndUpdatePayrollPeriodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computePayrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePayslipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPayrollWorkdaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(1040, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello, ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEmployeeToolStripMenuItem,
            this.userCredentialsToolStripMenuItem,
            this.payrollToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1395, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEmployeeRecordToolStripMenuItem,
            this.viewAndUpdateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.manageEmployeeToolStripMenuItem.Text = "Employee Records";
            // 
            // createEmployeeRecordToolStripMenuItem
            // 
            this.createEmployeeRecordToolStripMenuItem.Name = "createEmployeeRecordToolStripMenuItem";
            this.createEmployeeRecordToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.createEmployeeRecordToolStripMenuItem.Text = "Create employee record";
            this.createEmployeeRecordToolStripMenuItem.Click += new System.EventHandler(this.createEmployeeRecordToolStripMenuItem_Click);
            // 
            // viewAndUpdateToolStripMenuItem
            // 
            this.viewAndUpdateToolStripMenuItem.Name = "viewAndUpdateToolStripMenuItem";
            this.viewAndUpdateToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.viewAndUpdateToolStripMenuItem.Text = "View and Update";
            this.viewAndUpdateToolStripMenuItem.Click += new System.EventHandler(this.viewAndUpdateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.deleteToolStripMenuItem.Text = "Delete ";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // userCredentialsToolStripMenuItem
            // 
            this.userCredentialsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateLoginsToolStripMenuItem,
            this.updatePasswordToolStripMenuItem});
            this.userCredentialsToolStripMenuItem.Name = "userCredentialsToolStripMenuItem";
            this.userCredentialsToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.userCredentialsToolStripMenuItem.Text = "User Credentials";
            this.userCredentialsToolStripMenuItem.Click += new System.EventHandler(this.userCredentialsToolStripMenuItem_Click);
            // 
            // generateLoginsToolStripMenuItem
            // 
            this.generateLoginsToolStripMenuItem.Name = "generateLoginsToolStripMenuItem";
            this.generateLoginsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.generateLoginsToolStripMenuItem.Text = "Generate logins";
            this.generateLoginsToolStripMenuItem.Click += new System.EventHandler(this.generateLoginsToolStripMenuItem_Click);
            // 
            // updatePasswordToolStripMenuItem
            // 
            this.updatePasswordToolStripMenuItem.Name = "updatePasswordToolStripMenuItem";
            this.updatePasswordToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updatePasswordToolStripMenuItem.Text = "Update password";
            this.updatePasswordToolStripMenuItem.Click += new System.EventHandler(this.updatePasswordToolStripMenuItem_Click);
            // 
            // payrollToolStripMenuItem
            // 
            this.payrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAndUpdatePayrollPeriodToolStripMenuItem,
            this.computePayrollToolStripMenuItem,
            this.generatePayslipToolStripMenuItem,
            this.createPayrollWorkdaysToolStripMenuItem});
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.payrollToolStripMenuItem.Text = "Payroll";
            // 
            // viewAndUpdatePayrollPeriodToolStripMenuItem
            // 
            this.viewAndUpdatePayrollPeriodToolStripMenuItem.Name = "viewAndUpdatePayrollPeriodToolStripMenuItem";
            this.viewAndUpdatePayrollPeriodToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.viewAndUpdatePayrollPeriodToolStripMenuItem.Text = "View and Update Payroll period";
            this.viewAndUpdatePayrollPeriodToolStripMenuItem.Click += new System.EventHandler(this.viewAndUpdatePayrollPeriodToolStripMenuItem_Click);
            // 
            // computePayrollToolStripMenuItem
            // 
            this.computePayrollToolStripMenuItem.Name = "computePayrollToolStripMenuItem";
            this.computePayrollToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.computePayrollToolStripMenuItem.Text = "Compute Payroll";
            // 
            // generatePayslipToolStripMenuItem
            // 
            this.generatePayslipToolStripMenuItem.Name = "generatePayslipToolStripMenuItem";
            this.generatePayslipToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.generatePayslipToolStripMenuItem.Text = "Generate payslip";
            // 
            // createPayrollWorkdaysToolStripMenuItem
            // 
            this.createPayrollWorkdaysToolStripMenuItem.Name = "createPayrollWorkdaysToolStripMenuItem";
            this.createPayrollWorkdaysToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.createPayrollWorkdaysToolStripMenuItem.Text = "create payroll workdays";
            this.createPayrollWorkdaysToolStripMenuItem.Click += new System.EventHandler(this.createPayrollWorkdaysToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1307, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.FloralWhite;
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 30);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1395, 918);
            this.main_panel.TabIndex = 3;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1395, 948);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Page";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEmployeeRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAndUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userCredentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateLoginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem viewAndUpdatePayrollPeriodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computePayrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatePayslipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPayrollWorkdaysToolStripMenuItem;
        private System.Windows.Forms.Panel main_panel;
    }
}