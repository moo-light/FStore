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
    public partial class frmAdmin : Form
    {
        private Member user;
       private frmMembers frmMembers;
        public Member User { get => user; set => user = value; }

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMembers = new frmMembers();
            this.Close();
            frmMembers.ShowDialog();

        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
            frmProduct.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport reportForm = new frmReport();
            reportForm.ShowDialog();
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
        private void btnMember_Click(object sender, EventArgs e)
        {
            frmMembers frmMembers = new frmMembers();
            this.Hide();
            frmMembers.Show();
        }
    }
}
