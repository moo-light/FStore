using BusinessObject.Models;
using DataAccess.Repository.dao;
using DealersManagementProgram.tool;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            txtPassword.PasswordChar = '*';
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please input Email");
                return;
            }
            if (txtPassword.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please input Password");
                return;
            }
            var email = txtEmail.Text;
            var password = txtPassword.Text;

            //compute hash from the bytes of text  

            //get hash result after compute it  
            var hashedpassword = MyTool.encryptData(password);
            var user =MemberDAO.GetLoginedAccount(email, password);

            if(user == null)
            {
                MessageBox.Show("Login Failed");
                return;
            }
            if (user.Role.Equals("admin")){
                frmAdmin frmAdmin = new frmAdmin(user);
                this.Hide();
                frmAdmin.Show();
            }
            else
            {
                frmUser frmUser = new frmUser(user);
                this.Hide();
                frmUser.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
