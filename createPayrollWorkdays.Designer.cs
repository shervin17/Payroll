namespace PayrollV1
{
    partial class createPayrollWorkdays
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datefromTB = new System.Windows.Forms.TextBox();
            this.commentTB = new System.Windows.Forms.TextBox();
            this.dateTB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ratecb = new System.Windows.Forms.ComboBox();
            this.PayrollPeriodTB = new System.Windows.Forms.TextBox();
            this.addRow = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.submitWorkDays = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.period_options = new System.Windows.Forms.ComboBox();
            this.dateToTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payroll period ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "date from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(714, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "date to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "comment";
            // 
            // datefromTB
            // 
            this.datefromTB.Enabled = false;
            this.datefromTB.Location = new System.Drawing.Point(492, 58);
            this.datefromTB.Name = "datefromTB";
            this.datefromTB.Size = new System.Drawing.Size(206, 22);
            this.datefromTB.TabIndex = 7;
            // 
            // commentTB
            // 
            this.commentTB.Location = new System.Drawing.Point(205, 208);
            this.commentTB.MaxLength = 250;
            this.commentTB.Multiline = true;
            this.commentTB.Name = "commentTB";
            this.commentTB.Size = new System.Drawing.Size(297, 78);
            this.commentTB.TabIndex = 11;
            // 
            // dateTB
            // 
            this.dateTB.Location = new System.Drawing.Point(205, 93);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(200, 22);
            this.dateTB.TabIndex = 12;
            this.dateTB.Validating += new System.ComponentModel.CancelEventHandler(this.dateTB_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "working day type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Regular Working Day",
            "Regular Holiday",
            "Special Holiday"});
            this.comboBox1.Location = new System.Drawing.Point(205, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ratecb
            // 
            this.ratecb.Enabled = false;
            this.ratecb.FormattingEnabled = true;
            this.ratecb.Items.AddRange(new object[] {
            "1.0",
            "2.0",
            "1.3"});
            this.ratecb.Location = new System.Drawing.Point(205, 165);
            this.ratecb.Name = "ratecb";
            this.ratecb.Size = new System.Drawing.Size(200, 24);
            this.ratecb.TabIndex = 15;
            // 
            // PayrollPeriodTB
            // 
            this.PayrollPeriodTB.Enabled = false;
            this.PayrollPeriodTB.Location = new System.Drawing.Point(205, 58);
            this.PayrollPeriodTB.Name = "PayrollPeriodTB";
            this.PayrollPeriodTB.Size = new System.Drawing.Size(206, 22);
            this.PayrollPeriodTB.TabIndex = 6;
            // 
            // addRow
            // 
            this.addRow.BackColor = System.Drawing.Color.Lime;
            this.addRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRow.Location = new System.Drawing.Point(508, 236);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(131, 35);
            this.addRow.TabIndex = 16;
            this.addRow.Text = "add row";
            this.addRow.UseVisualStyleBackColor = false;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.table.Location = new System.Drawing.Point(66, 308);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(946, 217);
            this.table.TabIndex = 17;
            // 
            // submitWorkDays
            // 
            this.submitWorkDays.BackColor = System.Drawing.Color.DodgerBlue;
            this.submitWorkDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitWorkDays.ForeColor = System.Drawing.SystemColors.Desktop;
            this.submitWorkDays.Location = new System.Drawing.Point(807, 559);
            this.submitWorkDays.Name = "submitWorkDays";
            this.submitWorkDays.Size = new System.Drawing.Size(205, 40);
            this.submitWorkDays.TabIndex = 18;
            this.submitWorkDays.Text = "Submit";
            this.submitWorkDays.UseVisualStyleBackColor = false;
            this.submitWorkDays.Click += new System.EventHandler(this.submitWorkDays_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1246, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.button1.Size = new System.Drawing.Size(118, 47);
            this.button1.TabIndex = 19;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(653, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 35);
            this.button2.TabIndex = 20;
            this.button2.Text = "upload csv";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // download
            // 
            this.download.BackColor = System.Drawing.Color.White;
            this.download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download.ForeColor = System.Drawing.Color.Blue;
            this.download.Location = new System.Drawing.Point(790, 236);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(182, 35);
            this.download.TabIndex = 21;
            this.download.Text = "download csv format";
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(596, 559);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 40);
            this.button3.TabIndex = 22;
            this.button3.Text = "Discard";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // period_options
            // 
            this.period_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_options.FormattingEnabled = true;
            this.period_options.Location = new System.Drawing.Point(205, 21);
            this.period_options.Name = "period_options";
            this.period_options.Size = new System.Drawing.Size(390, 28);
            this.period_options.TabIndex = 23;
            this.period_options.SelectedIndexChanged += new System.EventHandler(this.period_options_SelectedIndexChanged);
            // 
            // dateToTB
            // 
            this.dateToTB.Enabled = false;
            this.dateToTB.Location = new System.Drawing.Point(768, 58);
            this.dateToTB.Name = "dateToTB";
            this.dateToTB.Size = new System.Drawing.Size(206, 22);
            this.dateToTB.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Payroll period ";
            // 
            // createPayrollWorkdays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 732);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.period_options);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.download);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitWorkDays);
            this.Controls.Add(this.table);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.ratecb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.commentTB);
            this.Controls.Add(this.dateToTB);
            this.Controls.Add(this.datefromTB);
            this.Controls.Add(this.PayrollPeriodTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createPayrollWorkdays";
            this.ShowInTaskbar = false;
            this.Text = "b";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.createPayrollWorkdays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox datefromTB;
        private System.Windows.Forms.TextBox commentTB;
        private System.Windows.Forms.DateTimePicker dateTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox ratecb;
        private System.Windows.Forms.TextBox PayrollPeriodTB;
        private System.Windows.Forms.Button addRow;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button submitWorkDays;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox period_options;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dateToTB;
    }
}