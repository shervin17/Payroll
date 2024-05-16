namespace PayrollV1
{
    partial class UpdateEmployee
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.midname = new System.Windows.Forms.TextBox();
            this.hourlyTB = new System.Windows.Forms.TextBox();
            this.monthlyTB = new System.Windows.Forms.TextBox();
            this.yearlyTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.posTB = new System.Windows.Forms.ComboBox();
            this.save_draft = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.datehired = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Middlename";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "date hired";
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(45, 24);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 22);
            this.ID.TabIndex = 6;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(105, 52);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(174, 22);
            this.fname.TabIndex = 1;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(105, 81);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(174, 22);
            this.lname.TabIndex = 2;
            // 
            // midname
            // 
            this.midname.Location = new System.Drawing.Point(105, 110);
            this.midname.Name = "midname";
            this.midname.Size = new System.Drawing.Size(174, 22);
            this.midname.TabIndex = 3;
            // 
            // hourlyTB
            // 
            this.hourlyTB.Enabled = false;
            this.hourlyTB.Location = new System.Drawing.Point(508, 113);
            this.hourlyTB.Name = "hourlyTB";
            this.hourlyTB.Size = new System.Drawing.Size(174, 22);
            this.hourlyTB.TabIndex = 8;
            // 
            // monthlyTB
            // 
            this.monthlyTB.Location = new System.Drawing.Point(508, 84);
            this.monthlyTB.Name = "monthlyTB";
            this.monthlyTB.Size = new System.Drawing.Size(174, 22);
            this.monthlyTB.TabIndex = 7;
            this.monthlyTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox6_KeyDown);
            // 
            // yearlyTB
            // 
            this.yearlyTB.Enabled = false;
            this.yearlyTB.Location = new System.Drawing.Point(508, 141);
            this.yearlyTB.Name = "yearlyTB";
            this.yearlyTB.Size = new System.Drawing.Size(174, 22);
            this.yearlyTB.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Posiition";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "monthly salary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "hourly_rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "yearly rate";
            // 
            // posTB
            // 
            this.posTB.FormattingEnabled = true;
            this.posTB.Items.AddRange(new object[] {
            "Cashier",
            "Bagger",
            "Utilities",
            "Assistant Manager",
            "Manager"});
            this.posTB.Location = new System.Drawing.Point(508, 51);
            this.posTB.Name = "posTB";
            this.posTB.Size = new System.Drawing.Size(174, 24);
            this.posTB.TabIndex = 6;
            // 
            // save_draft
            // 
            this.save_draft.Location = new System.Drawing.Point(383, 188);
            this.save_draft.Name = "save_draft";
            this.save_draft.Size = new System.Drawing.Size(137, 29);
            this.save_draft.TabIndex = 8;
            this.save_draft.Text = "save draft";
            this.save_draft.UseVisualStyleBackColor = true;
            this.save_draft.Click += new System.EventHandler(this.save_draft_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(526, 188);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(137, 29);
            this.resetbtn.TabIndex = 9;
            this.resetbtn.Text = "reset fields";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(335, 337);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(117, 23);
            this.savebtn.TabIndex = 10;
            this.savebtn.Text = "save update";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(458, 337);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(117, 23);
            this.cancelbtn.TabIndex = 11;
            this.cancelbtn.Text = "close";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 223);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(939, 97);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(104, 144);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(175, 22);
            this.dob.TabIndex = 20;
            // 
            // datehired
            // 
            this.datehired.Location = new System.Drawing.Point(104, 178);
            this.datehired.Name = "datehired";
            this.datehired.Size = new System.Drawing.Size(175, 22);
            this.datehired.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(717, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Employment Status";
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "in probation",
            "regular",
            "inactive",
            "terminated"});
            this.status.Location = new System.Drawing.Point(845, 50);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(121, 24);
            this.status.TabIndex = 23;
            this.status.Text = "in probation";
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.datehired);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.save_draft);
            this.Controls.Add(this.posTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yearlyTB);
            this.Controls.Add(this.monthlyTB);
            this.Controls.Add(this.hourlyTB);
            this.Controls.Add(this.midname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateEmployee";
            this.Load += new System.EventHandler(this.UpdateEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox midname;
        private System.Windows.Forms.TextBox hourlyTB;
        private System.Windows.Forms.TextBox monthlyTB;
        private System.Windows.Forms.TextBox yearlyTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox posTB;
        private System.Windows.Forms.Button save_draft;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.DateTimePicker datehired;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox status;
    }
}