using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private FstoreDbContext _db;

        public ProductRepository(FstoreDbContext db)
        {
            _db = new FstoreDbContext();
        }
        public void Create(Product p)
        {
            if (p is not null)
            {
                _db.Add(p);
                _db.SaveChanges();
            }
        }

        public Product Get(int id)
        {
            return this.GetAllProduct().SingleOrDefault(x => x.ProductId == id);
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return this._db.Products.ToList();
        }


        public void Remove(Product p)
        {
            if (p is not null)
            {
                _db.Remove(p);
                _db.SaveChanges();
            }
        }

        public void Update(Product p)
        {
            if (p is not null)
            {
                _db.Update(p);
                _db.SaveChanges();
            }
        }
    }
}