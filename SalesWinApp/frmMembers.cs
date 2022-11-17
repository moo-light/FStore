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
        public frmAddMember _frmAddMember ;
        private frmAdmin frmAdmin;
        public frmMembers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          var context = txtSearchMem.Text;
            LoadMemberAccount(context); 
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
            dgvMembers.DataSource = null;
            dgvMembers.DataSource = _bindingSrc;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadMemberAccount();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var member = _memberRepository.GetAlls().ToArray()[_bindingSrc.Position];
            _memberRepository.Remove(member);
            LoadMemberAccount();
            MessageBox.Show("Deleted");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

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
    }
}
