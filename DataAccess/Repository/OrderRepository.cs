using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private FstoreDbContext _db;

        public OrderRepository(FstoreDbContext db)
        {
            _db = new FstoreDbContext();
        }
        public void Create(Order o)
        {
            if (o is not null)
            {
                _db.Add(o);
                _db.SaveChanges();
            }
        }

        public Order Get(int id)
        {
            return this.GetAlls().FirstOrDefault(x => x.OrderId == id);
        }

        public IEnumerable<Order> GetAlls()
        {
            return this._db.Orders.ToList();
        }

        public void Remove(Order o)
        {
            if (o is not null)
            {
                _db.Remove(o);
                _db.SaveChanges();
            }
        }

        public void Update(Order o)
        {
            if (o is not null)
            {
                _db.Update(o);
                _db.SaveChanges();
            }
        }
    }
}
