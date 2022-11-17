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
    public partial class frmMember : Form
    {

        private IMemberRepository _member = new MemberRepository();
        private BindingSource _bindingSource;
        public frmMember()
        {
            InitializeComponent();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            LoadMember();   
        }

        private void LoadMember() {
            var members = _member.GetAlls();
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = members;
          dgvMembers.DataSource = null;
            dgvMembers.DataSource = _bindingSource;
        
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
