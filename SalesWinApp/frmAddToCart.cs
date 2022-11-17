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
        private IProductRepository _product= new ProductRepository();
        private CartObject cartObj = new CartObject();
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
