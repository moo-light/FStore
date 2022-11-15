using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.dao
{
    public class MemberDAO 
    {
        private static IMemberRepository _member = new MemberRepository();

        public static IEnumerable<Member> GetMembers() => _member.GetAlls();
        public static Member GetMemberByID(int id) => _member.Get(id);
        public static Member GetLoginedAccount(string email, string password) 
            => _member.GetAlls().FirstOrDefault(x=>x.Email.Equals(email) && x.Password.Equals(password));

    }
}
