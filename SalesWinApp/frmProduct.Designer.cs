namespace SalesWinApp
{
    partial class frmProduct
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.txtMinStock = new System.Windows.Forms.TextBox();
            this.txtMaxStock = new System.Windows.Forms.TextBox();
            this.Keyword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(717, 534);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(115, 534);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(86, 31);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(303, 534);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 31);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(504, 534);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(413, 120);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(12, 168);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 25;
            this.dgvProduct.Size = new System.Drawing.Size(940, 340);
            this.dgvProduct.TabIndex = 5;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(203, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 27);
            this.txtSearch.TabIndex = 6;
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "ID",
            "ProductName"});
            this.cboSearchBy.Location = new System.Drawing.Point(203, 74);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(125, 28);
            this.cboSearchBy.TabIndex = 7;
            this.cboSearchBy.Text = "ProductName";
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(551, 33);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.PlaceholderText = "Min price";
            this.txtMinPrice.Size = new System.Drawing.Size(125, 27);
            this.txtMinPrice.TabIndex = 8;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(682, 33);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.PlaceholderText = "Max price";
            this.txtMaxPrice.Size = new System.Drawing.Size(125, 27);
            this.txtMaxPrice.TabIndex = 9;
            // 
            // txtMinStock
            // 
            this.txtMinStock.Location = new System.Drawing.Point(551, 75);
            this.txtMinStock.Name = "txtMinStock";
            this.txtMinStock.PlaceholderText = "Min stock";
            this.txtMinStock.Size = new System.Drawing.Size(125, 27);
            this.txtMinStock.TabIndex = 10;
            // 
            // txtMaxStock
            // 
            this.txtMaxStock.Location = new System.Drawing.Point(682, 75);
            this.txtMaxStock.Name = "txtMaxStock";
            this.txtMaxStock.PlaceholderText = "max stock";
            this.txtMaxStock.Size = new System.Drawing.Size(125, 27);
            this.txtMaxStock.TabIndex = 11;
            // 
            // Keyword
            // 
            this.Keyword.AutoSize = true;
            this.Keyword.Location = new System.Drawing.Point(134, 36);
            this.Keyword.Name = "Keyword";
            this.Keyword.Size = new System.Drawing.Size(67, 20);
            this.Keyword.TabIndex = 12;
            this.Keyword.Text = "Keyword";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Stock";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(134, 78);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(40, 20);
            this.Type.TabIndex = 15;
            this.Type.Text = "Type";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 600);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Keyword);
            this.Controls.Add(this.txtMaxStock);
            this.Controls.Add(this.txtMinStock);
            this.Controls.Add(this.txtMaxPrice);
            this.Controls.Add(this.txtMinPrice);
            this.Controls.Add(this.cboSearchBy);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProduct";
            this.Text = "Product Management";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private DataGridView dgvProduct;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txtSearch;
        private ComboBox cboSearchBy;
        private TextBox txtMinPrice;
        private TextBox txtMaxPrice;
        private TextBox txtMinStock;
        private TextBox txtMaxStock;
        private Label Keyword;
        private Label label1;
        private Label label2;
        private Label Type;
    }
}