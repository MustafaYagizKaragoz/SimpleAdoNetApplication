namespace AdoNetDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgwProducts = new DataGridView();
            gbxAdd = new GroupBox();
            btnAdd = new Button();
            tbxStockAmount = new TextBox();
            tbxUnitPrice = new TextBox();
            tbxName = new TextBox();
            lblStockAmount = new Label();
            lblUnitPrice = new Label();
            lblName = new Label();
            gbxUpdate = new GroupBox();
            btnUpdate = new Button();
            tbxStockAmountUpdate = new TextBox();
            tbxUnitPriceUpdate = new TextBox();
            tbxNameUpdate = new TextBox();
            lblStockAmountUpdate = new Label();
            lblUnitPriceUpdate = new Label();
            lblNameUpdate = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            gbxAdd.SuspendLayout();
            gbxUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(31, 41);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowHeadersWidth = 51;
            dgwProducts.Size = new Size(676, 188);
            dgwProducts.TabIndex = 0;
            dgwProducts.CellClick += dgwProducts_CellClick;
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(tbxStockAmount);
            gbxAdd.Controls.Add(tbxUnitPrice);
            gbxAdd.Controls.Add(tbxName);
            gbxAdd.Controls.Add(lblStockAmount);
            gbxAdd.Controls.Add(lblUnitPrice);
            gbxAdd.Controls.Add(lblName);
            gbxAdd.Location = new Point(31, 235);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(332, 182);
            gbxAdd.TabIndex = 1;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Add a Product";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(125, 147);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += AddDB_Click;
            // 
            // tbxStockAmount
            // 
            tbxStockAmount.Location = new Point(141, 111);
            tbxStockAmount.Name = "tbxStockAmount";
            tbxStockAmount.Size = new Size(125, 27);
            tbxStockAmount.TabIndex = 5;
            // 
            // tbxUnitPrice
            // 
            tbxUnitPrice.Location = new Point(141, 78);
            tbxUnitPrice.Name = "tbxUnitPrice";
            tbxUnitPrice.Size = new Size(125, 27);
            tbxUnitPrice.TabIndex = 4;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(141, 43);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(125, 27);
            tbxName.TabIndex = 3;
            // 
            // lblStockAmount
            // 
            lblStockAmount.AutoSize = true;
            lblStockAmount.Location = new Point(33, 111);
            lblStockAmount.Name = "lblStockAmount";
            lblStockAmount.Size = new Size(102, 20);
            lblStockAmount.TabIndex = 2;
            lblStockAmount.Text = "Stock Amount";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(33, 75);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(72, 20);
            lblUnitPrice.TabIndex = 1;
            lblUnitPrice.Text = "Unit Price";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(33, 43);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(btnUpdate);
            gbxUpdate.Controls.Add(tbxStockAmountUpdate);
            gbxUpdate.Controls.Add(tbxUnitPriceUpdate);
            gbxUpdate.Controls.Add(tbxNameUpdate);
            gbxUpdate.Controls.Add(lblStockAmountUpdate);
            gbxUpdate.Controls.Add(lblUnitPriceUpdate);
            gbxUpdate.Controls.Add(lblNameUpdate);
            gbxUpdate.Location = new Point(423, 235);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(332, 182);
            gbxUpdate.TabIndex = 7;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "Update A Product";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Location = new Point(125, 147);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxStockAmountUpdate
            // 
            tbxStockAmountUpdate.Location = new Point(141, 111);
            tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            tbxStockAmountUpdate.Size = new Size(125, 27);
            tbxStockAmountUpdate.TabIndex = 5;
            // 
            // tbxUnitPriceUpdate
            // 
            tbxUnitPriceUpdate.Location = new Point(141, 78);
            tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            tbxUnitPriceUpdate.Size = new Size(125, 27);
            tbxUnitPriceUpdate.TabIndex = 4;
            // 
            // tbxNameUpdate
            // 
            tbxNameUpdate.Location = new Point(141, 43);
            tbxNameUpdate.Name = "tbxNameUpdate";
            tbxNameUpdate.Size = new Size(125, 27);
            tbxNameUpdate.TabIndex = 3;
            // 
            // lblStockAmountUpdate
            // 
            lblStockAmountUpdate.AutoSize = true;
            lblStockAmountUpdate.Location = new Point(33, 111);
            lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            lblStockAmountUpdate.Size = new Size(102, 20);
            lblStockAmountUpdate.TabIndex = 2;
            lblStockAmountUpdate.Text = "Stock Amount";
            // 
            // lblUnitPriceUpdate
            // 
            lblUnitPriceUpdate.AutoSize = true;
            lblUnitPriceUpdate.Location = new Point(33, 75);
            lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            lblUnitPriceUpdate.Size = new Size(72, 20);
            lblUnitPriceUpdate.TabIndex = 1;
            lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // lblNameUpdate
            // 
            lblNameUpdate.AutoSize = true;
            lblNameUpdate.Location = new Point(33, 43);
            lblNameUpdate.Name = "lblNameUpdate";
            lblNameUpdate.Size = new Size(49, 20);
            lblNameUpdate.TabIndex = 0;
            lblNameUpdate.Text = "Name";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(31, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(gbxUpdate);
            Controls.Add(gbxAdd);
            Controls.Add(dgwProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            gbxUpdate.ResumeLayout(false);
            gbxUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProducts;
        private GroupBox gbxAdd;
        private Button btnAdd;
        private TextBox tbxStockAmount;
        private TextBox tbxUnitPrice;
        private TextBox tbxName;
        private Label lblStockAmount;
        private Label lblUnitPrice;
        private Label lblName;
        private GroupBox gbxUpdate;
        private Button btnUpdate;
        private TextBox tbxStockAmountUpdate;
        private TextBox tbxUnitPriceUpdate;
        private TextBox tbxNameUpdate;
        private Label lblStockAmountUpdate;
        private Label lblUnitPriceUpdate;
        private Label lblNameUpdate;
        private Button btnDelete;
    }
}
