using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.dao
{
    public class ProductDAO
    {
        private static IProductRepository _product = new ProductRepository();
        public static IEnumerable<Product> GetAlls()
        {
            return _product.GetAllProducts();
        }
    }
}
