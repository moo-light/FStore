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
    public partial class frmUser : Form
    {
        private Member user;

        public frmUser()
        {
            InitializeComponent();
        }

        public frmUser(Member user)
        {
            this.user = user;
        }
    }
}
