namespace PayrollV1
{
    partial class Employee_login_form
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_Field = new System.Windows.Forms.TextBox();
            this.password_Field = new System.Windows.Forms.TextBox();
            this.submitBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // username_Field
            // 
            this.username_Field.Location = new System.Drawing.Point(132, 70);
            this.username_Field.Name = "username_Field";
            this.username_Field.Size = new System.Drawing.Size(199, 22);
            this.username_Field.TabIndex = 2;
            this.username_Field.TextChanged += new System.EventHandler(this.username_Field_TextChanged);
            // 
            // password_Field
            // 
            this.password_Field.Location = new System.Drawing.Point(132, 116);
            this.password_Field.Name = "password_Field";
            this.password_Field.Size = new System.Drawing.Size(199, 22);
            this.password_Field.TabIndex = 3;
            this.password_Field.TextChanged += new System.EventHandler(this.password_Field_TextChanged);
            // 
            // submitBTN
            // 
            this.submitBTN.Location = new System.Drawing.Point(132, 171);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(75, 23);
            this.submitBTN.TabIndex = 4;
            this.submitBTN.Text = "login";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(231, 171);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelBTN.TabIndex = 5;
            this.cancelBTN.Text = "cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Employee_login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.password_Field);
            this.Controls.Add(this.username_Field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Employee_login_form";
            this.Text = "Employee_login_form";
            this.Load += new System.EventHandler(this.Employee_login_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_Field;
        private System.Windows.Forms.TextBox password_Field;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}