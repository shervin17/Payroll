namespace PayrollV1
{
    partial class ResetPassword
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.findbyIDbtn = new System.Windows.Forms.Button();
            this.ID_field = new System.Windows.Forms.TextBox();
            this.searchAllBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(468, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ResetBTN
            // 
            this.ResetBTN.Location = new System.Drawing.Point(37, 254);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(94, 23);
            this.ResetBTN.TabIndex = 1;
            this.ResetBTN.Text = "Reset Password";
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Id";
            // 
            // findbyIDbtn
            // 
            this.findbyIDbtn.Location = new System.Drawing.Point(232, 35);
            this.findbyIDbtn.Name = "findbyIDbtn";
            this.findbyIDbtn.Size = new System.Drawing.Size(75, 23);
            this.findbyIDbtn.TabIndex = 3;
            this.findbyIDbtn.Text = "search";
            this.findbyIDbtn.UseVisualStyleBackColor = true;
            this.findbyIDbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ID_field
            // 
            this.ID_field.Location = new System.Drawing.Point(126, 36);
            this.ID_field.Name = "ID_field";
            this.ID_field.Size = new System.Drawing.Size(100, 22);
            this.ID_field.TabIndex = 4;
            // 
            // searchAllBtn
            // 
            this.searchAllBtn.Location = new System.Drawing.Point(324, 35);
            this.searchAllBtn.Name = "searchAllBtn";
            this.searchAllBtn.Size = new System.Drawing.Size(82, 23);
            this.searchAllBtn.TabIndex = 5;
            this.searchAllBtn.Text = "search all";
            this.searchAllBtn.UseVisualStyleBackColor = true;
            this.searchAllBtn.Click += new System.EventHandler(this.searchAllBtn_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchAllBtn);
            this.Controls.Add(this.ID_field);
            this.Controls.Add(this.findbyIDbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetBTN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ResetPassword";
            this.Text = "UpdatePassword";
            this.Load += new System.EventHandler(this.UpdatePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findbyIDbtn;
        private System.Windows.Forms.TextBox ID_field;
        private System.Windows.Forms.Button searchAllBtn;
    }
}