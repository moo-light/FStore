using BusinessObject.Models;
using DataAccess.Repository;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProduct : Form
    {
        private readonly IProductRepository _repository = new ProductRepository();
        private BindingSource _source;

        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }
        private void LoadProduct()
        {
            var products = _repository.AllProduct.Select(
                p => new
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    Weight = p.Weight,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock,
                    CategoryName = p.Category.CategoryName
                }
                );

            _source = new BindingSource();
            _source.DataSource = products;
            dgvProduct.DataSource = _source;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var products = _repository.AllProduct.Select(
                p => new
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    Weight = p.Weight,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock,
                    CategoryName = p.Category.CategoryName
                }
                );

            var minPriceText = txtMinPrice.Text;
            var maxPriceText = txtMaxPrice.Text;
            if (!minPriceText.IsNullOrEmpty() && !maxPriceText.IsNullOrEmpty())
            {
                try
                {
                    int minPrice = Int32.Parse(minPriceText);
                    int maxPrice = Int32.Parse(maxPriceText);

                    if (minPrice > maxPrice)
                    {
                        throw new InvalidDataException("Min price must be smaller than max price.");
                    }
                    products = products.Where(x => x.UnitPrice >= minPrice && x.UnitPrice <= maxPrice);

                }
                catch (InvalidDataException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You must type number!");
                }
            }

            var minStockText = txtMinStock.Text;
            var maxStockText = txtMaxStock.Text;
            if (!minStockText.IsNullOrEmpty() && !maxStockText.IsNullOrEmpty())
            {
                try
                {
                    int minStock = Int32.Parse(minStockText);
                    int maxStock = Int32.Parse(maxStockText);

                    if (minStock > maxStock)
                    {
                        throw new InvalidDataException("Min stock must be smaller than max stock.");
                    }
                    products = products.Where(x => x.UnitsInStock >= minStock && x.UnitsInStock <= maxStock);

                }
                catch (InvalidDataException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You must type number!");
                }
            }

            var search = txtSearch.Text.ToUpper();
            var searchBy = cboSearchBy.Text;
            if (!search.IsNullOrEmpty())
            {
                if (searchBy.Equals("ID"))
                {
                    products = products.Where(x => x.ProductId.ToString().Equals(search));
                }
                else if (searchBy.Equals("ProductName"))
                {
                    products = products.Where(x => x.ProductName.ToUpper().Contains(search.ToUpper().Trim()));
                }
            }

            _source = new BindingSource();
            _source.DataSource = products;
            dgvProduct.DataSource = _source;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you want to create new item?", "Confirm create", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                frmAddProduct frmAddProduct = new frmAddProduct()
                {
                    UpdateOrAdd = false,
                    ProductRepository = _repository,
                };
                if (frmAddProduct.ShowDialog() == DialogResult.OK)
                {
                    frmAddProduct.Hide();
                    LoadProduct();
                    _source.Position = _source.Count - 1;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you want to update this item?", "Confirm update", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                frmAddProduct frmAddProduct = new frmAddProduct()
                {
                    UpdateOrAdd = true,
                    ProductRepository = _repository,
                    Product = _repository.Get(Int32.Parse(dgvProduct.CurrentRow.Cells[0].Value.ToString())),
                };
                if (frmAddProduct.ShowDialog() == DialogResult.OK)
                {
                    frmAddProduct.Hide();
                    LoadProduct();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you want to delete this item?", "Confirm delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var account = _repository.Get(Int32.Parse(dgvProduct.CurrentRow.Cells[0].Value.ToString()));
                _repository.Remove(account);
                LoadProduct();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
