namespace SalesWinApp
{
    partial class frmManager
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(77, 87);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(210, 119);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Project Management";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(428, 87);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(210, 119);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View Orders History";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 291);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnProfile);
            this.Name = "frmManager";
            this.Text = "cuuem";
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnProfile;
        private Button btnView;
    }
}