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
    public partial class frmReport : Form
    {
        private readonly IOrderRepository _repository = new OrderRepository();
        private BindingSource _source;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }
        private void LoadOrder(DateTime startDate, DateTime endDate)
        {
            var orders = from order in _repository.GetOrders()
                         where order.OrderDate >=startDate && order.OrderDate <= endDate
                         select new {Member = order.Member.Email,
                                     OrderID = order.OrderId,
                                     OrderDate = order.OrderDate,
                                     Sales = this._repository.GetTotalBill(order.OrderId)
                         };

            _source = new BindingSource();
            _source.DataSource = null;
            _source.DataSource = orders.ToList();
            dgvReport.DataSource = _source;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dtpStartDate.Value > DateTime.Now)
            {
                MessageBox.Show("The start date must be less than today.");
            } else if (dtpEndDate.Value < dtpStartDate.Value)
            {
                MessageBox.Show("The end date must be greater than start date.");
            } else
            {
                LoadOrder(dtpStartDate.Value, dtpEndDate.Value);
            }
        }
    }
}
