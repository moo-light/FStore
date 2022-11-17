using BusinessObject.CartObject;
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
        IEnumerable<Product> _products = ProductDAO.GetAlls();
        private Product selectedProduct = null;
        private CartObject cartObj = new();
        private BindingSource _source = new BindingSource();
        
        public frmAddToCart()
        {
            InitializeComponent();
        }

        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        { selectedProduct = _products.ToArray()[cboProducts.SelectedIndex];
            txtProductName.Text = selectedProduct.ProductName;
            txtProductPrice.Text= selectedProduct.UnitPrice.ToString();
            lbStock.te
        }

        private void frmOrderAddDetail_Load(object sender, EventArgs e)
        {
            

            var proName = _products.Select(x=>x.ProductName).ToArray();
            cboProducts.Items.Clear();
            cboProducts.Items.AddRange(proName);
            cboProducts.SelectedIndex = 0;
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        { 
        }
    }
}
