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
    public partial class frmOrderHistory : Form
    {
       private  OrderRepository _order = new OrderRepository();
        public BindingSource _src;

        public frmOrderHistory()
        {
            InitializeComponent();
        }

        private void frmOrderHistory_Load(object sender, EventArgs e)
        {
            LoadOrderHistory();

        }

        private void dgvOrderHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     private void   LoadOrderHistory() {
            var order = _order.GetAlls();
            _src = new BindingSource();
        _src.DataSource = order;
            dgvOrderHistory.DataSource = null;
            dgvOrderHistory.DataSource = _src;
        }
    }
}
