namespace SalesWinApp
{
    partial class frmMain
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
            this.mnuAdmin = new System.Windows.Forms.MenuStrip();
            this.tsmMember = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewMember = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewMember = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mnuManager = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mnuManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMember,
            this.tsmProduct,
            this.tsmOrder,
            this.tsReport,
            this.toolsMenu,
            this.windowsMenu});
            this.mnuAdmin.Location = new System.Drawing.Point(0, 0);
            this.mnuAdmin.MdiWindowListItem = this.windowsMenu;
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuAdmin.Size = new System.Drawing.Size(738, 28);
            this.mnuAdmin.TabIndex = 0;
            this.mnuAdmin.Text = "MenuStrip";
            // 
            // tsmMember
            // 
            this.tsmMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewMember,
            this.btnNewMember});
            this.tsmMember.Image = global::SalesWinApp.Properties.Resources.icons8_customer_26;
            this.tsmMember.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.tsmMember.Name = "tsmMember";
            this.tsmMember.Size = new System.Drawing.Size(84, 24);
            this.tsmMember.Text = "&Member";
            // 
            // btnViewMember
            // 
            this.btnViewMember.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnViewMember.Name = "btnViewMember";
            this.btnViewMember.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.btnViewMember.Size = new System.Drawing.Size(214, 22);
            this.btnViewMember.Text = "&View Member List";
            this.btnViewMember.Click += new System.EventHandler(this.ShowMembers);
            // 
            // btnNewMember
            // 
            this.btnNewMember.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.M)));
            this.btnNewMember.Size = new System.Drawing.Size(214, 22);
            this.btnNewMember.Text = "&New Member";
            this.btnNewMember.Click += new System.EventHandler(this.AddMember);
            // 
            // tsmProduct
            // 
            this.tsmProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewProduct,
            this.btnNewProduct});
            this.tsmProduct.Image = global::SalesWinApp.Properties.Resources.icons8_package_64;
            this.tsmProduct.Name = "tsmProduct";
            this.tsmProduct.Size = new System.Drawing.Size(81, 24);
            this.tsmProduct.Text = "&Product";
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(180, 22);
            this.btnViewProduct.Text = "View Product List";
            this.btnViewProduct.Click += new System.EventHandler(this.ShowProducts);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(180, 22);
            this.btnNewProduct.Text = "New Product";
            this.btnNewProduct.Click += new System.EventHandler(this.AddProduct);
            // 
            // tsmOrder
            // 
            this.tsmOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewOrder,
            this.btnNewOrder});
            this.tsmOrder.Image = global::SalesWinApp.Properties.Resources.icons8_purchase_order_50;
            this.tsmOrder.Name = "tsmOrder";
            this.tsmOrder.Size = new System.Drawing.Size(69, 24);
            this.tsmOrder.Text = "&Order";
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(180, 22);
            this.btnViewOrder.Text = "View Order History";
            this.btnViewOrder.Click += new System.EventHandler(this.ShowOrders);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(180, 22);
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.Click += new System.EventHandler(this.AddOrder);
            // 
            // tsReport
            // 
            this.tsReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewReport});
            this.tsReport.Name = "tsReport";
            this.tsReport.Size = new System.Drawing.Size(54, 24);
            this.tsReport.Text = "&Report";
            // 
            // btnViewReport
            // 
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(158, 22);
            this.btnViewReport.Text = "View Report List";
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(46, 24);
            this.toolsMenu.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(68, 24);
            this.windowsMenu.Text = "&Windows";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 501);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStrip.Size = new System.Drawing.Size(738, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // mnuManager
            // 
            this.mnuManager.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem7,
            this.toolStripMenuItem12,
            this.toolStripMenuItem14});
            this.mnuManager.Location = new System.Drawing.Point(0, 28);
            this.mnuManager.MdiWindowListItem = this.toolStripMenuItem7;
            this.mnuManager.Name = "mnuManager";
            this.mnuManager.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuManager.Size = new System.Drawing.Size(738, 28);
            this.mnuManager.TabIndex = 4;
            this.mnuManager.Text = "MenuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewProfile});
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItem1.Text = "&Profile";
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.btnViewProfile.Size = new System.Drawing.Size(181, 22);
            this.btnViewProfile.Text = "&View Profile";
            this.btnViewProfile.Click += new System.EventHandler(this.UpdateProfile);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8});
            this.toolStripMenuItem7.Image = global::SalesWinApp.Properties.Resources.icons8_purchase_order_50;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(69, 24);
            this.toolStripMenuItem7.Text = "&Order";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem8.Text = "View Order History";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.ShowOrders);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13});
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem12.Text = "&Tools";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem13.Text = "&Options";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripMenuItem18,
            this.toolStripMenuItem19,
            this.toolStripMenuItem20});
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(68, 24);
            this.toolStripMenuItem14.Text = "&Windows";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem16.Text = "&Cascade";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem17.Text = "Tile &Vertical";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem18.Text = "Tile &Horizontal";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem19.Text = "C&lose All";
            this.toolStripMenuItem19.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem20.Text = "&Arrange Icons";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.btnNewAccount});
            this.toolStripMenuItem2.Image = global::SalesWinApp.Properties.Resources.icons8_customer_26;
            this.toolStripMenuItem2.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(84, 24);
            this.toolStripMenuItem2.Text = "&Member";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem3.Text = "&View Member List";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ShowMembers);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.M)));
            this.btnNewAccount.Size = new System.Drawing.Size(214, 22);
            this.btnNewAccount.Text = "&New Account";
            this.btnNewAccount.Click += new System.EventHandler(this.AddMember);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 523);
            this.Controls.Add(this.mnuManager);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mnuAdmin);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuAdmin;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuAdmin.ResumeLayout(false);
            this.mnuAdmin.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mnuManager.ResumeLayout(false);
            this.mnuManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip mnuAdmin;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmMember;
        private System.Windows.Forms.ToolStripMenuItem btnViewMember;
        private System.Windows.Forms.ToolStripMenuItem btnNewMember;
        private System.Windows.Forms.ToolStripMenuItem tsmOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmProduct;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem btnViewProduct;
        private ToolStripMenuItem btnNewProduct;
        private ToolStripMenuItem btnViewOrder;
        private ToolStripMenuItem btnNewOrder;
        private ToolStripMenuItem tsReport;
        private ToolStripMenuItem btnViewReport;
        private MenuStrip mnuManager;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem btnViewProfile;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem toolStripMenuItem13;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripMenuItem toolStripMenuItem17;
        private ToolStripMenuItem toolStripMenuItem18;
        private ToolStripMenuItem toolStripMenuItem19;
        private ToolStripMenuItem toolStripMenuItem20;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem btnNewAccount;
    }
}



