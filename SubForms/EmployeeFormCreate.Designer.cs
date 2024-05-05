namespace PayrollV1.SubForms
{
    partial class EmployeeGenerator
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
            System.Windows.Forms.Button SaveBTN;
            System.Windows.Forms.Button reset;
            System.Windows.Forms.Button cancelbtn;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.fnameTB = new System.Windows.Forms.TextBox();
            this.lnameTB = new System.Windows.Forms.TextBox();
            this.midnameTB = new System.Windows.Forms.TextBox();
            this.salaryTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hourly_rateTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.yearlySalaryTB = new System.Windows.Forms.TextBox();
            this.postionCb = new System.Windows.Forms.ComboBox();
            this.EmployeeListView = new System.Windows.Forms.ListView();
            this.salaryError = new System.Windows.Forms.ErrorProvider(this.components);
            this.save_draft = new System.Windows.Forms.Button();
            this.reset_fields = new System.Windows.Forms.Button();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.datehired = new System.Windows.Forms.DateTimePicker();
            SaveBTN = new System.Windows.Forms.Button();
            reset = new System.Windows.Forms.Button();
            cancelbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salaryError)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBTN
            // 
            SaveBTN.AutoSize = true;
            SaveBTN.Location = new System.Drawing.Point(449, 385);
            SaveBTN.Name = "SaveBTN";
            SaveBTN.Size = new System.Drawing.Size(103, 26);
            SaveBTN.TabIndex = 10;
            SaveBTN.Text = "Save";
            SaveBTN.UseVisualStyleBackColor = true;
            SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // reset
            // 
            reset.Location = new System.Drawing.Point(605, 385);
            reset.Name = "reset";
            reset.Size = new System.Drawing.Size(103, 23);
            reset.TabIndex = 11;
            reset.Text = "Reset ";
            reset.UseVisualStyleBackColor = true;
            reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // cancelbtn
            // 
            cancelbtn.Location = new System.Drawing.Point(739, 385);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new System.Drawing.Size(103, 23);
            cancelbtn.TabIndex = 12;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Middle name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "date hired";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "monthly salary";
            // 
            // idTB
            // 
            this.idTB.Enabled = false;
            this.idTB.Location = new System.Drawing.Point(39, 22);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 22);
            this.idTB.TabIndex = 9;
            // 
            // fnameTB
            // 
            this.fnameTB.Location = new System.Drawing.Point(103, 54);
            this.fnameTB.Name = "fnameTB";
            this.fnameTB.Size = new System.Drawing.Size(212, 22);
            this.fnameTB.TabIndex = 1;
            this.fnameTB.Text = "kulas";
            // 
            // lnameTB
            // 
            this.lnameTB.Location = new System.Drawing.Point(103, 85);
            this.lnameTB.Name = "lnameTB";
            this.lnameTB.Size = new System.Drawing.Size(212, 22);
            this.lnameTB.TabIndex = 2;
            this.lnameTB.Text = "Mananabas";
            // 
            // midnameTB
            // 
            this.midnameTB.Location = new System.Drawing.Point(103, 121);
            this.midnameTB.Name = "midnameTB";
            this.midnameTB.Size = new System.Drawing.Size(212, 22);
            this.midnameTB.TabIndex = 3;
            this.midnameTB.Text = "Test";
            // 
            // salaryTB
            // 
            this.salaryTB.Location = new System.Drawing.Point(543, 85);
            this.salaryTB.Name = "salaryTB";
            this.salaryTB.Size = new System.Drawing.Size(212, 22);
            this.salaryTB.TabIndex = 5;
            this.salaryTB.Text = "50000";
            this.salaryTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.salaryTB_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(427, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "hourly_rate";
            // 
            // hourly_rateTB
            // 
            this.hourly_rateTB.Enabled = false;
            this.hourly_rateTB.Location = new System.Drawing.Point(543, 118);
            this.hourly_rateTB.Name = "hourly_rateTB";
            this.hourly_rateTB.Size = new System.Drawing.Size(212, 22);
            this.hourly_rateTB.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(427, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "yearly_salary";
            // 
            // yearlySalaryTB
            // 
            this.yearlySalaryTB.Enabled = false;
            this.yearlySalaryTB.Location = new System.Drawing.Point(543, 158);
            this.yearlySalaryTB.Name = "yearlySalaryTB";
            this.yearlySalaryTB.Size = new System.Drawing.Size(212, 22);
            this.yearlySalaryTB.TabIndex = 20;
            // 
            // postionCb
            // 
            this.postionCb.FormattingEnabled = true;
            this.postionCb.Items.AddRange(new object[] {
            "Cashier",
            "Bagger",
            "Utilities",
            "Assistant Manager",
            "Manager"});
            this.postionCb.Location = new System.Drawing.Point(543, 49);
            this.postionCb.Name = "postionCb";
            this.postionCb.Size = new System.Drawing.Size(211, 24);
            this.postionCb.TabIndex = 4;
            this.postionCb.Text = "Manager";
            // 
            // EmployeeListView
            // 
            this.EmployeeListView.HideSelection = false;
            this.EmployeeListView.Location = new System.Drawing.Point(15, 268);
            this.EmployeeListView.Name = "EmployeeListView";
            this.EmployeeListView.Size = new System.Drawing.Size(1334, 97);
            this.EmployeeListView.TabIndex = 25;
            this.EmployeeListView.UseCompatibleStateImageBehavior = false;
            // 
            // salaryError
            // 
            this.salaryError.ContainerControl = this;
            // 
            // save_draft
            // 
            this.save_draft.Location = new System.Drawing.Point(400, 205);
            this.save_draft.Name = "save_draft";
            this.save_draft.Size = new System.Drawing.Size(152, 29);
            this.save_draft.TabIndex = 8;
            this.save_draft.Text = "save draft";
            this.save_draft.UseVisualStyleBackColor = true;
            this.save_draft.Click += new System.EventHandler(this.save_draft_Click);
            // 
            // reset_fields
            // 
            this.reset_fields.Location = new System.Drawing.Point(558, 205);
            this.reset_fields.Name = "reset_fields";
            this.reset_fields.Size = new System.Drawing.Size(150, 29);
            this.reset_fields.TabIndex = 9;
            this.reset_fields.Text = "reset fields";
            this.reset_fields.UseVisualStyleBackColor = true;
            this.reset_fields.Click += new System.EventHandler(this.button1_Click);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(103, 164);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(212, 22);
            this.dob.TabIndex = 26;
            // 
            // datehired
            // 
            this.datehired.Location = new System.Drawing.Point(103, 200);
            this.datehired.Name = "datehired";
            this.datehired.Size = new System.Drawing.Size(212, 22);
            this.datehired.TabIndex = 27;
            // 
            // EmployeeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 553);
            this.Controls.Add(this.datehired);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.reset_fields);
            this.Controls.Add(this.save_draft);
            this.Controls.Add(this.EmployeeListView);
            this.Controls.Add(cancelbtn);
            this.Controls.Add(reset);
            this.Controls.Add(SaveBTN);
            this.Controls.Add(this.postionCb);
            this.Controls.Add(this.yearlySalaryTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.hourly_rateTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.salaryTB);
            this.Controls.Add(this.midnameTB);
            this.Controls.Add(this.lnameTB);
            this.Controls.Add(this.fnameTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeGenerator";
            this.ShowIcon = false;
            this.Text = "Create Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaryError)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox fnameTB;
        private System.Windows.Forms.TextBox lnameTB;
        private System.Windows.Forms.TextBox midnameTB;
        private System.Windows.Forms.TextBox salaryTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox hourly_rateTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox yearlySalaryTB;
        private System.Windows.Forms.ComboBox postionCb;
        private System.Windows.Forms.ListView EmployeeListView;
        private System.Windows.Forms.ErrorProvider salaryError;
        private System.Windows.Forms.Button reset_fields;
        private System.Windows.Forms.Button save_draft;
        private System.Windows.Forms.DateTimePicker datehired;
        private System.Windows.Forms.DateTimePicker dob;
    }
}