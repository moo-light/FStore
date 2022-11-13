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
        IEnumerable<Member> GetAlls();
        IEnumerable<Member> Get(int id);
        void Create(Member o);
        void Update(Member o);
        void Remove(Member o);
    }
}
