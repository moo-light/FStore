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

    }
}
