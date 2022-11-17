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
        frmUser frmUser = new frmUser();
        
        public frmManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUser.Show();
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
