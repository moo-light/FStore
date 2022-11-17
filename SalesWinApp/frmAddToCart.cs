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
            lbStock.Text = selectedProduct.UnitsInStock.ToString();
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
            if (cartObj == null) cartObj = new CartObject();
            cartObj.AddToCart(selectedProduct.ProductId);

        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            try
            {
                cartObj.Cart.Add(2, 1);
                cartObj.Cart.Add(5, 3);
                cartObj.Cart.Add(3, 4);
                var productList = new List<Product>();
                foreach (int key in cartObj.Cart.Keys)
                {
                    var product = this._product.Get(key);
                    productList.Add(product);
                }
                var dataList = from pd in productList
                               select new { 
                                   ProductID = pd.ProductId,
                                   ProductName = pd.ProductName,
                                   UnitPrice = pd.UnitPrice,
                                   UnitInStock = pd.UnitsInStock
                               };
                BindingSource source = new BindingSource();
                source.DataSource = null;
                source.DataSource = dataList.ToList();
                dgvCart.DataSource = source;
            } catch (Exception ex)
            {
                MessageBox.Show("Add to cart. " + ex.Message);
            }

        }
    }
}
