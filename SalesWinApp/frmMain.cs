using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public Member User { get; internal set; }

        public frmMain()
        {
            InitializeComponent();
        }

        
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void windowsMenu_Click(object sender, EventArgs e)
        {

        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }
        private void ShowMembers(object sender, EventArgs e)
        {
            var childForm = new frmMembers() { };
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void AddMember(object sender, EventArgs e)
        {
            var childForm = new frmAddMember() { };
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void ShowOrders(object sender, EventArgs e)
        {
            var childForm = new frmOrders() { };
            childForm.MdiParent = this;
            childForm.Show();
        }
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (this.User.Role.Equals("admin"))
            {
                mnuManager.Hide();
            }
            else if( this.User.Role.Equals("member"))
            {
                mnuAdmin.Hide();

            }
        }

        private void UpdateProfile(object sender, EventArgs e)
        {
            frmUserProfile frmUserProfile = new frmUserProfile()
            {
                User = User
                
            };
            if (frmUserProfile.ShowDialog() == DialogResult.OK)
            {
                //change something
            }

        }

        private void tsmProduct_Click(object sender, EventArgs e)
        {
            var childForm = new frmProduct() { };
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void tsmOrder_Click(object sender, EventArgs e)
        {
            var childForm = new frmOrderHistory() { };
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void viewOrderHistoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var childForm = new frmOrderHistory();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void Logout(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            var check = new frmOrderHistory();
            check.MdiParent = this;
            check.Show();
        }

        private void tsReport_Click(object sender, EventArgs e)
        {
            var childForm = new frmReport() { };
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void tsmMakeOrder_Click(object sender, EventArgs e)
        {

            var childForm = new frmAddToCart() {
            User = User
            };
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
