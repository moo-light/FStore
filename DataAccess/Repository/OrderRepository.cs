using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private FStoreDBContext _db;

        public MemberRepository(FStoreDBContext db)
        {
            _db = new FStoreDBContext();
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
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAlls()
        {
            throw new NotImplementedException();
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
