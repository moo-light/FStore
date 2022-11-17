namespace SalesWinApp
{
    partial class frmOrderHistory
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
            this.dgvOrderHistory = new System.Windows.Forms.DataGridView();
            this.btnViewDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderHistory
            // 
            this.dgvOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderHistory.Location = new System.Drawing.Point(12, 32);
            this.dgvOrderHistory.Name = "dgvOrderHistory";
            this.dgvOrderHistory.RowHeadersWidth = 51;
            this.dgvOrderHistory.RowTemplate.Height = 29;
            this.dgvOrderHistory.Size = new System.Drawing.Size(972, 377);
            this.dgvOrderHistory.TabIndex = 0;
            this.dgvOrderHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderHistory_CellContentClick);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Location = new System.Drawing.Point(872, 447);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(94, 29);
            this.btnViewDetail.TabIndex = 1;
            this.btnViewDetail.Text = "View Detail";
            this.btnViewDetail.UseVisualStyleBackColor = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // frmOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 508);
            this.Controls.Add(this.btnViewDetail);
            this.Controls.Add(this.dgvOrderHistory);
            this.Name = "frmOrderHistory";
            this.Text = "frmOrderHistory";
            this.Load += new System.EventHandler(this.frmOrderHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvOrderHistory;
        private Button btnViewDetail;
    }
}