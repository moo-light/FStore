using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private FStoreDBContext _db;

        public MemberRepository(FStoreDBContext db)
        {
            _db = new FStoreDBContext();
        }
        public void Create(Product p)
        {
            if (p is not null)
            {
                _db.Add(o);
                _db.SaveChanges();
            }
        }

        public Product Get(int id)
        {
            return this.GetAlls().SingleOrDefault(x => x.productId == id);
        }

        public IEnumerable<Product> GetAlls()
        {
            return this._db.Products.ToList();
        }

        public void Remove(Product p)
        {
            if (p is not null)
            {
                _db.Remove(o);
                _db.SaveChanges();
            }
        }

        public void Update(Product p)
        {
            if (p is not null)
            {
                _db.Update(o);
                _db.SaveChanges();
            }
        }
    }
}
