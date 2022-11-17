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
    
    public partial class frmManager : Form
    {
       private  frmUserProfile _frmUser;
        private Member _member;
        //private Member user;
        //private frmMembers frmMembers;
        public Member User { get => _member; set => _member = value; }

        public frmManager()
        {
            InitializeComponent();
        }
        public frmManager(Member member)
        {
        this._member = member;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _frmUser = new frmUserProfile();
         _frmUser.User= _member;
            this.Hide();
            _frmUser.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Show();

        }

        private void frmManager_Load(object sender, EventArgs e)
        {

        }

      
    }
}
