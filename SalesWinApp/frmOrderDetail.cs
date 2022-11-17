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
        public IOrderRepository _order = new OrderRepository();
        private BindingSource _source = new();
        public int OrderIdDetail { get; set; }
        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {

        }

private void  LoadOrderDetail(String orderID1 = null)
        {
           
        }
    }
}
