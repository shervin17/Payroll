namespace PayrollV1
{
    partial class ProductForm
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
            this.amount = new System.Windows.Forms.TextBox();
            this.product = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.id_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InsertBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.findAllBTN = new System.Windows.Forms.Button();
            this.delBTN = new System.Windows.Forms.Button();
            this.find_by_ID = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(23, 54);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(160, 22);
            this.amount.TabIndex = 0;
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(23, 105);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(160, 22);
            this.product.TabIndex = 1;
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(27, 159);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(160, 22);
            this.qty.TabIndex = 2;
            // 
            // id_field
            // 
            this.id_field.Location = new System.Drawing.Point(453, 12);
            this.id_field.Name = "id_field";
            this.id_field.Size = new System.Drawing.Size(160, 22);
            this.id_field.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(212, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(563, 265);
            this.dataGridView1.TabIndex = 7;
            // 
            // InsertBTN
            // 
            this.InsertBTN.Location = new System.Drawing.Point(212, 341);
            this.InsertBTN.Name = "InsertBTN";
            this.InsertBTN.Size = new System.Drawing.Size(75, 23);
            this.InsertBTN.TabIndex = 8;
            this.InsertBTN.Text = "insert";
            this.InsertBTN.UseVisualStyleBackColor = true;
            this.InsertBTN.Click += new System.EventHandler(this.InsertBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Location = new System.Drawing.Point(314, 341);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(75, 23);
            this.UpdateBTN.TabIndex = 9;
            this.UpdateBTN.Text = "update";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // findAllBTN
            // 
            this.findAllBTN.Location = new System.Drawing.Point(406, 341);
            this.findAllBTN.Name = "findAllBTN";
            this.findAllBTN.Size = new System.Drawing.Size(75, 23);
            this.findAllBTN.TabIndex = 10;
            this.findAllBTN.Text = "find all";
            this.findAllBTN.UseVisualStyleBackColor = true;
            this.findAllBTN.Click += new System.EventHandler(this.findAllBTN_Click);
            // 
            // delBTN
            // 
            this.delBTN.Location = new System.Drawing.Point(500, 341);
            this.delBTN.Name = "delBTN";
            this.delBTN.Size = new System.Drawing.Size(75, 23);
            this.delBTN.TabIndex = 11;
            this.delBTN.Text = "delete";
            this.delBTN.UseVisualStyleBackColor = true;
            // 
            // find_by_ID
            // 
            this.find_by_ID.Location = new System.Drawing.Point(619, 11);
            this.find_by_ID.Name = "find_by_ID";
            this.find_by_ID.Size = new System.Drawing.Size(75, 23);
            this.find_by_ID.TabIndex = 12;
            this.find_by_ID.Text = "find by ID";
            this.find_by_ID.UseVisualStyleBackColor = true;
            this.find_by_ID.Click += new System.EventHandler(this.find_by_ID_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(212, 408);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(563, 97);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.find_by_ID);
            this.Controls.Add(this.delBTN);
            this.Controls.Add(this.findAllBTN);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.InsertBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_field);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.product);
            this.Controls.Add(this.amount);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox product;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.TextBox id_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button InsertBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button findAllBTN;
        private System.Windows.Forms.Button delBTN;
        private System.Windows.Forms.Button find_by_ID;
        private System.Windows.Forms.ListView listView1;
    }
}