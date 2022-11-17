using BusinessObject.Models;
using DataAccess.Repository;
using Microsoft.IdentityModel.Tokens;
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
    public partial class frmAddMember : Form
    {
        public IMemberRepository memberRepository = new MemberRepository();
        private Member _member;
        public bool UpdateOrAdd { get; set; }  //false => add 
        public Member Member { get => _member; set => _member = value; }
        //private frmMembers _mem = new frmMembers();
        public frmAddMember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddMember_Load(object sender, EventArgs e)
        {
            if (UpdateOrAdd)
            {
                txtEmail.Text = _member.Email;
                txtCity.Text = _member.City;
                txtCompanyName.Text = _member.CompanyName;
                txtCountry.Text = _member.Country;
                cboActived.Text = _member.Actived.ToString();
                txtPassword.Text = _member.Password;
                cboRole.Text = _member.Role;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please input member's email", this.Text);
            }
            else if (txtPassword.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please input member's password", this.Text);

            }
            else if (cboRole.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please set member's role", this.Text);
            }
            else if (cboActived.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please set member's status", this.Text);
            }
            else
            {
                try
                {
                    if (UpdateOrAdd)
                    {
                        _member.Email = txtEmail.Text;
                        _member.Password = txtPassword.Text;
                        _member.City = txtCity.Text;
                        _member.Role = cboRole.Text;
                        _member.CompanyName = txtCompanyName.Text;
                        _member.Country = txtCountry.Text;
                        _member.Actived = Boolean.Parse(cboActived.Text);
                        memberRepository.Update(_member);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        _member = new Member();
                        _member.Email = txtEmail.Text;
                        _member.Password = txtPassword.Text;
                        _member.City = txtCity.Text;
                        _member.Role = cboRole.Text;
                        _member.CompanyName = txtCompanyName.Text;
                        _member.Country = txtCountry.Text;
                        _member.Actived = Boolean.Parse(cboActived.Text);
                        memberRepository.Create(_member);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
