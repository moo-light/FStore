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
    public partial class frmAddToCart : Form
    {
        private IProductRepository _product= new ProductRepository();
        private Product selectedProduct = null;
        private BindingSource _source = new BindingSource();
        
        public frmAddToCart()
        {
            InitializeComponent();
        }

        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmOrderAddDetail_Load(object sender, EventArgs e)
        {
            IEnumerable<Product> products = _product.GetAllProducts();
            _source.DataSource = products;
            selectedProduct = products.First();
            var proName = products.Select(x=>x.ProductName).ToArray();
            cboProducts.Items.Clear();
            cboProducts.Items.AddRange(proName);
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        { 
        }
    }
}
