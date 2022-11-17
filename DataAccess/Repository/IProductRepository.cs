using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProduct { get; }
        IEnumerable<Category> GetAllCategory();
        Product Get(int id);
        void Create(Product p);
        void Update(Product p);
        void Remove(Product p);
        IEnumerable<Product> GetAllProducts();
    }
}
