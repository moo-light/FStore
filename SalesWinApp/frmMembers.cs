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
            LoadProduct();
        }
        private void LoadProduct()
        {
            var members = _repository.GetAlls().Select(
                m => new {
                    MemberID = m.MemberID,
                    Email = m.Email,
                    Password = m.Password,
                    Role = m.Role,
                    CompanyName = m.CompanyName,
                    City = m.City,
                    Country = m.Country,
                    Status = m.Status,
                }
                );

            _source = new BindingSource();
            _source.DataSource = members;
            dgvMember.DataSource = _source;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
