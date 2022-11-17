using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
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


        //public OrderRepository(FstoreDbContext db) // xoa cai nay nha
        //{
        //    _db = new FstoreDbContext();
        //}

        public OrderRepository()
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
        public void CreateNoSave(Order o)
        {
            if (o is not null)
            {
                _db.Add(o);
            }
        }
        public void SaveChanges()
        {
            _db.SaveChanges();
        }
        public Order Get(int id)
        {
            return this._db.Orders.Include("OrderDetails").Include("Member").FirstOrDefault(x => x.OrderId == id);
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

        public DbSet<Order> GetOrders()
        {
            return this._db.Orders;
        }

        public decimal? GetTotalBill(int OrderID)
        {
            this._db = new FstoreDbContext();
           Order order = this.Get(OrderID);
           List<Order> orderDetails = order.OrderDetails.ToList();
           decimal? totalBill = 0;
           foreach (Order detail in orderDetails)
           {
             totalBill += detail.UnitPrice * (decimal)(1 - detail.Discount) * detail.Quantity;
            }
            totalBill += order.Freight;
            return totalBill;
        }
    }
}
