using BusinessObject.Models;
using DataAccess.Repository;
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
        private void LoadProduct(string search = null)
        {
            //1. lay toan bo account tu db
            var products = _repository.GetAllProduct().Select(
                p => new {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    Weight = p.Weight,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock,
                    CategoryName = p.Category.CategoryName
                }
                );

            if (search != null)
            {
                products = products.Where(x => x.ProductName.ToUpper().Contains(search.ToUpper().Trim()));
            }

            _source = new BindingSource();
            _source.DataSource = products;
            //2. add to dgv
            dgvProduct.DataSource = _source;

        }

    }

    


}
