namespace SalesWinApp
{
    partial class frmAdmin
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
            this.btnMember = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(22, 169);
            this.btnMember.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.btnMember.Name = "btnMember";
            this.btnMember.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnMember.Size = new System.Drawing.Size(169, 63);
            this.btnMember.TabIndex = 0;
            this.btnMember.Text = "Member Management";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(270, 169);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnProduct.Size = new System.Drawing.Size(169, 63);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Product Management";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(22, 259);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnOrder.Size = new System.Drawing.Size(169, 63);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order Management";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(270, 259);
            this.btnReport.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnReport.Size = new System.Drawing.Size(169, 63);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Report Management";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(461, 348);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdmin";
            this.Text = "Admin Management";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMember;
        private Button btnProduct;
        private Button btnOrder;
        private Button btnReport;
    }
}