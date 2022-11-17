using DataAccess.Repository;
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

        public IMemberRepository _memberRepository = new MemberRepository();
        //private frmAddMember frmAddMember = new frmAddMember();
        private BindingSource _bindingSrc;
        public frmAddMember _frmAddMember;

        public frmMembers()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
              
        private void txtSearchMem_TextChanged(object sender, EventArgs e)
        {

        }

        private void  LoadMemberAccount(string search = null) {

            var members = _memberRepository.GetAlls();
            if (search != null) {
                members = members.Where(a => a.Email.ToUpper().Contains(search.ToUpper().Trim()));
            }
            _bindingSrc = new BindingSource();
            _bindingSrc.DataSource = members;
            dgvMember.DataSource = null;
            dgvMember.DataSource = _bindingSrc;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadMember();
        }
        private void LoadMember()
        {
            
            var members = _memberRepository.GetAlls();

            _bindingSrc = new BindingSource();

            _bindingSrc.DataSource = members;

            dgvMember.DataSource = null;
            dgvMember.DataSource = _bindingSrc;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateMemberDetail frmCreateMemberDetail = new frmCreateMemberDetail
            {
                UpdateOrAdd = false,
                MemberRepository = _memberRepository
            };
            if (frmCreateMemberDetail.ShowDialog() == DialogResult.OK)
            {
                frmCreateMemberDetail.Hide();
                LoadMember();
                _bindingSrc.Position = _bindingSrc.Count - 1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _frmAddMember = new frmAddMember();
            this.Close();
            _frmAddMember.Show();
            
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void frmMembers_Load_1(object sender, EventArgs e)
        {

        }
    }
}
