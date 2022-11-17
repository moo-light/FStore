using BusinessObject.Models;
using DataAccess.Repository;
using DataAccess.Repository.dao;
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
    public partial class frmUserProfile : Form
    {
        public Member _member;
        public Member User { get => _member; set => _member = value; }
        IMemberRepository memberRepository = new MemberRepository();
        public frmUserProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            txtCity.Text = User.City;
            txtCountry.Text = User.Country;
            txtEmail.Text = User.Email;
            txtCompanyName.Text = User.CompanyName;
            txtPassword.Text = User.Password;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User.Email = txtEmail.Text;
            User.City =  txtCity.Text;
            User.CompanyName= txtCompanyName.Text;
            User.Country = txtCountry.Text;
            User.Password = txtChangePassword.Text;
            if (!txtChangePassword.Text.Equals(txtRePassword.Text)) {
                MessageBox.Show("Password not match");
            }
            else { 
            
            memberRepository.Update(User);
                MessageBox.Show("Change Infomation Success");

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
