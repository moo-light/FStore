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
        private readonly IMemberRepository _memberRepo
            = new MemberRepository();
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
            
            var members = _memberRepo.GetAlls();

            _source = new BindingSource();

            _source.DataSource = members;

            dgvMember.DataSource = null;
            dgvMember.DataSource = _source;

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
                MemberRepository = _memberRepo
            };
            if (frmCreateMemberDetail.ShowDialog() == DialogResult.OK)
            {
                frmCreateMemberDetail.Hide();
                LoadMember();
                _source.Position = _source.Count - 1;
            }
        }
    }
}
