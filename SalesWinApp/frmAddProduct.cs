using BusinessObject.Models;
using DataAccess.Repository;
using Microsoft.IdentityModel.Tokens;
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
    public partial class frmAddProduct : Form
    {
        public IProductRepository ProductRepository = new ProductRepository();
        private Product _product;
        public bool UpdateOrAdd { get; set; }  //false => add 
        public Product Product { get => _product; set => _product = value; }

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please input product name", this.Text);
            }
            else if (txtWeight.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please input weight", this.Text);

            }
            else if (txtPrice.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please input price", this.Text);
            }
            else if (txtStock.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Units in stock must >= 0", this.Text);
            }
            else
            {
                if (UpdateOrAdd)
                {
                    _product.ProductName = txtProductName.Text;
                    _product.Weight = txtWeight.Text;
                    _product.UnitPrice = Decimal.Parse(txtPrice.Text);
                    _product.UnitsInStock = Int32.Parse(txtStock.Text);
                    _product.CategoryId = GetCategoryIDByName(cboCategory.Text);
                    _product.Category = GetCategoryByName(cboCategory.Text);
                    ProductRepository.Update(_product);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    _product = new Product();
                    _product.ProductName = txtProductName.Text;
                    _product.Weight = txtWeight.Text;
                    _product.UnitPrice = Decimal.Parse(txtPrice.Text);
                    _product.UnitsInStock = Int32.Parse(txtStock.Text);
                    _product.CategoryId = GetCategoryIDByName(cboCategory.Text);
                    _product.Category = GetCategoryByName(cboCategory.Text);
                    ProductRepository.Create(_product);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        private int GetCategoryIDByName(string name)
        {
            return ProductRepository.GetAllCategory().FirstOrDefault(c => c.CategoryName.Equals(name)).CategoryId;
        }

        private Category? GetCategoryByName(string name)
        {
            return ProductRepository.GetAllCategory().FirstOrDefault(c => c.CategoryName.Equals(name));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            var categories = ProductRepository.GetAllCategory().Select(x => x.CategoryName);
            cboCategory.Items.AddRange(categories.ToArray());

            if (UpdateOrAdd)
            {
                txtProductName.Text = _product.ProductName;
                txtWeight.Text = _product.Weight;
                txtPrice.Text = _product.UnitPrice.ToString();
                txtStock.Text = _product.UnitsInStock.ToString();
                cboCategory.Text = _product.Category?.CategoryName;
            }
            else
            {
                cboCategory.SelectedIndex = 0;
            }
        }
    }

    
}
