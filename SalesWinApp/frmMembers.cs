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
    public partial class frmMembers : Form
    {
        private readonly IMemberRepository _repository = new MemberRepository();
        private BindingSource _source;
        public frmMembers()
        {
            InitializeComponent();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadMember();
        }
        private void LoadMember()
        {
            var members = _repository.GetAlls().Select(
                m => new {
                    MemberID = m.MemberId,
                    Email = m.Email,
                    Password = m.Password,
                    Role = m.Role,
                    CompanyName = m.CompanyName,
                    City = m.City,
                    Country = m.Country,
                    Status = m.Actived
                }
                );

            _source = new BindingSource();
            _source.DataSource = members;
            dgvMember.DataSource = _source;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmAddMember frmAddMember = new frmAddMember()
            {
                UpdateOrAdd = false,
                memberRepository = _repository,
            };
            if (frmAddMember.ShowDialog() == DialogResult.OK)
            {
                frmAddMember.Hide();
                LoadMember();
                _source.Position = _source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmAddMember frmAddMember = new frmAddMember()
            {
                UpdateOrAdd = true,
                memberRepository = _repository,
                Member = _repository.GetAlls().ToList()[dgvMember.CurrentRow.Index]
            };
            if (frmAddMember.ShowDialog() == DialogResult.OK)
            {
                frmAddMember.Hide();
                LoadMember();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you want to delete this item?", "Confirm delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var account = _repository.GetAlls().ToList()[dgvMember.CurrentRow.Index];
                _repository.Remove(account);
                LoadMember();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
