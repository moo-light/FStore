using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAlls();
        Order Get(int id);
        void Create(Order o);
        void Update(Order o);
        void Remove(Order o);
    }
}
