using BusinessObject.Models;
using DataAccess.Repository;
using DataAccess.Repository.dao;
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
    public partial class frmOrderAddDetail : Form
    {
        private IProductRepository _product= new ProductRepository();
        private Product selectedProduct = null;
        public frmOrderAddDetail()
        {
            InitializeComponent();
        }

        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = _product.GetAllProducts().ToList()[cboProducts.SelectedIndex];
        }

        private void frmOrderAddDetail_Load(object sender, EventArgs e)
        {
            selectedProduct = _product.Get(1);
            var proName = _product.GetAllProducts().Select(x=>x.ProductName).ToArray();
            cboProducts.Items.Clear();
            cboProducts.Items.AddRange(proName);
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            
        }
    }
}
