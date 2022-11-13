using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private FstoreDbContext _db;

        public MemberRepository(FstoreDbContext db)
        {
            _db = new FstoreDbContext();
        }

        public IEnumerable<Member> GetAlls()
        {
            return _db.Members.ToList();
        }
        public Member Get(int id)
        {
            return GetAlls().SingleOrDefault(x=>x.MemberId == id);
        }
        public void Create(Member m)
        {
            if(m is not null)
            {
                _db.Add(m);
                _db.SaveChanges();
            }
        }
        public void Remove(Member m)
        {

            if (m is not null)
            {
                _db.Remove(m);
                _db.SaveChanges();
            }
        }

        public void Update(Member m)
        {

            if (m is not null)
            {
                _db.Update(m);
                _db.SaveChanges();
            }
        }
    }
}
