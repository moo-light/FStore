namespace SalesWinApp
{
    partial class frmAddToCart
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
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            lbStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new System.Drawing.Point(544, 71);
            lbStock.Name = "lbStock";
            lbStock.Size = new System.Drawing.Size(13, 15);
            lbStock.TabIndex = 9;
            lbStock.Text = "0";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(295, 14);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(120, 23);
            this.btnAddCart.TabIndex = 1;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnViewCart
            // 
            this.btnViewCart.Location = new System.Drawing.Point(34, 63);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(75, 31);
            this.btnViewCart.TabIndex = 2;
            this.btnViewCart.Text = "View Cart";
            this.btnViewCart.UseVisualStyleBackColor = true;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(34, 100);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowTemplate.Height = 25;
            this.dgvCart.Size = new System.Drawing.Size(704, 234);
            this.dgvCart.TabIndex = 3;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(634, 343);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(104, 31);
            this.btnCreateOrder.TabIndex = 2;
            this.btnCreateOrder.Text = "Make Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // cboProducts
            // 
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(34, 15);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(255, 23);
            this.cboProducts.TabIndex = 0;
            this.cboProducts.SelectedIndexChanged += new System.EventHandler(this.cboProducts_SelectedIndexChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(544, 15);
            this.txtProductName.Name = "txtProductName";

            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(202, 26);

            this.txtProductName.TabIndex = 4;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(544, 42);
            this.txtProductPrice.Name = "txtProductPrice";

            this.txtProductPrice.ReadOnly = true;
            this.txtProductPrice.Size = new System.Drawing.Size(202, 26);

            this.txtProductPrice.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(491, 71);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 15);
            this.label.TabIndex = 5;
            this.label.Text = "Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(34, 340);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 31);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove From Cart";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new System.Drawing.Point(622, 90);
            lbStock.Name = "lbStock";
            lbStock.Size = new System.Drawing.Size(17, 19);
            lbStock.TabIndex = 9;
            lbStock.Text = "0";
            // 
            // frmAddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 385);
            this.Controls.Add(lbStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnViewCart);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.cboProducts);
            this.Name = "frmAddToCart";
            this.Text = "Add To Cart";
            this.Load += new System.EventHandler(this.frmOrderAddDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAddCart;
        private Button btnViewCart;
        private DataGridView dgvCart;
        private Button btnCreateOrder;
        private ComboBox cboProducts;
        private TextBox txtProductName;
        private TextBox txtProductPrice;
        private Label label;
        private Label label1;
        private Label label2;
        private Label lbStock;
        private Button btnRemove;
    }
}