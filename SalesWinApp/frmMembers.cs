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
            dgvMember.CellClick += dgvMember_CellContentClick;
            btnDelete.Enabled = false;
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
            var confirmResult = MessageBox.Show("Do you want to add new member?", "Confirm create", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to update this member?", "Confirm update", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to delete this item?", "Confirm delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var account = _repository.GetAlls().ToList()[dgvMember.CurrentRow.Index];
                if(!account.Role.Equals("admin"))
                _repository.Remove(account);
                else
                {
                    MessageBox.Show("You Cant Remove Admin");
                }
                LoadMember();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMember.CurrentRow.Cells["Role"].Value.ToString().Equals("admin"))
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;

            }
        }
    }
}
