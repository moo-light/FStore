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
        private frmOrderDetail _orderDetail;
        public int orderID_detail;
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
            var order = _order.GetAlls().Where(a => a.OrderId == orderID_detail);
            _src = new BindingSource();
        _src.DataSource = order;
            dgvOrderHistory.DataSource = null;
            dgvOrderHistory.DataSource = _src;
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
           _orderDetail = new frmOrderDetail();
            _orderDetail.Show();
            var check = _order.GetAlls().ToArray()[_src.Position];
            orderID_detail = check.OrderId;
        }
    }
}
