using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetMemberById(int memberId);
        void InsertMember(Member member);
        void DeleteMember(int memberId);
        void UpdateMember(Member member);
        Boolean RegisterOrNot(string Email);
        Member Login(string Email, string Password);
    }
}