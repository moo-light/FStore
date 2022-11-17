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
    public partial class frmUser : Form
    {
        frmManager frmManager = new frmManager();   
        private Member user;

        public frmUser()
        {
            InitializeComponent();
        }

        public frmUser(Member user)
        {
            this.user = user;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManager.Show();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {

        }
    }
}
