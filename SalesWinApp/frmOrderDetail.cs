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
    public partial class frmOrderDetail : Form
    {
        public int orderID_detail { get; set; }
        
        private BindingSource _source = new();
        private IOrderDetailRepository _orderDetail = new OrderDetailRepository();
        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            LoadOrderDetail();
        }

private void  LoadOrderDetail()
        {
         
            var orderDetail = _orderDetail.GetAlls().Where(a => a.OrderId == orderID_detail);
        _source.DataSource = orderDetail;
            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.DataSource= _source;
            
        
        }

        private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
