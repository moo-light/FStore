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
        IProductRepository _product = new ProductRepository();
        private Product selectedProduct = null;
        private CartObject cartObj = new();
        private BindingSource _source = new BindingSource();

        public Member User { get; internal set; }

        public frmAddToCart()
        {
            InitializeComponent();
        }

        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = _products.ToArray()[cboProducts.SelectedIndex];
            txtProductName.Text = selectedProduct.ProductName;
            txtProductPrice.Text = selectedProduct.UnitPrice.ToString();
            lbStockk.Text = selectedProduct.UnitsInStock.ToString();
        }

        private void frmOrderAddDetail_Load(object sender, EventArgs e)
        {
            cartObj = new CartObject();
            var proName = _products.Select(x => x.ProductName).ToArray();
            cboProducts.Items.Clear();
            cboProducts.Items.AddRange(proName);
            cboProducts.SelectedIndex = 0;
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (selectedProduct.UnitsInStock <= 0)
            {
                MessageBox.Show("OUT OF STOCK!");
                return;
            }
            cartObj.AddToCart(selectedProduct.ProductId);
            selectedProduct.UnitsInStock -= 1;
            lbStockk.Text = selectedProduct.UnitsInStock.ToString();
            

        }
        private void LoadCartGridView()
        {
            try
            {
                var productList = new List<Product>();
                foreach (int key in cartObj.Cart.Keys)
                {
                    var product = this._product.Get(key);
                    productList.Add(product);
                }
                var dataList = from pd in productList
                               select new
                               {
                                   ProductID = pd.ProductId,
                                   ProductName = pd.ProductName,
                                   UnitPrice = pd.UnitPrice,
                                   Quantity = cartObj.Cart[pd.ProductId],
                                   InStock = pd.UnitsInStock,
                                   Price = pd.UnitPrice * cartObj.Cart[pd.ProductId]
                               };
                BindingSource source = new BindingSource();
                source.DataSource = null;
                source.DataSource = dataList.ToList();
                dgvCart.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("View cart. " + ex.Message);
            }
        }
        private void btnViewCart_Click(object sender, EventArgs e)
        {
            LoadCartGridView();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //var confirmResult = MessageBox.Show("Remove this item from cart?", "Confirm remove", MessageBoxButtons.YesNo);
            //if (confirmResult == DialogResult.Yes)
            //{
                var selectedProduct = _product.GetAllProducts().ToList()[dgvCart.CurrentRow.Index];
                cartObj.RemoveFromCart(selectedProduct.ProductId);
                LoadCartGridView();
            //}
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (OrderDAO.CreateOrder(cartObj.Cart, User) == true)
            {
                MessageBox.Show("Create Order Successful!");
                cartObj = new CartObject();
                dgvCart.DataSource = null;
            }
            else
            {
                MessageBox.Show("Create Order Failed!"); 
            }
        }
    }
}
