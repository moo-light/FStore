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
    public partial class frmCreateMemberDetail : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public bool UpdateOrAdd { get; set; } 
        private Member _member { get; set; }
        public frmCreateMemberDetail()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _member = new Member();

            _member.MemberId = int.Parse(txtMemberID.Text);
            _member.Email = txtEmail.Text;
            _member.Role = cboRole.Text;
            _member.CompanyName = txtCompanyName.Text;
            _member.City = txtCity.Text;
            _member.Country = txtCountry.Text;
            _member.Actived = Boolean.Parse(cboActive.Text);

            if (UpdateOrAdd)
            {

            }
            else
            {
                MemberRepository.Create(_member);
                this.DialogResult = DialogResult.OK;
            }
        }
        private void frmCreateMemberDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
