using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private FstoreDbContext _db;

        public OrderDetailRepository()
        {
            _db = new FstoreDbContext();
        }


       

        public OrderDetail Get(int orderID, int productID)
        {
            return GetAlls().SingleOrDefault(x => x.OrderId == orderID && x.ProductId == productID);
        }

        public IEnumerable<OrderDetail> GetAlls()
        {
            return _db.OrderDetails.ToList();
        }

       
        public void Create(OrderDetail o)
        {
            if (o is not null)
            {
                _db.Add(o);
                _db.SaveChanges();
            }
        }
        public void Update(OrderDetail o)
        {
            if (o is not null)
            {
                _db.Update(o);
                _db.SaveChanges();
            }
        }
        public void Remove(OrderDetail o)
        {
            if (o is not null)
            {
                _db.Remove(o);
                _db.SaveChanges();
            }
        }
    }
}
