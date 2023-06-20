using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class MemberRepository: IMemberRepository
    {
        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList();
        public Member GetMemberById(int memberId) => MemberDAO.Instance.GetMemberById(memberId);
        public void InsertMember(Member member) => MemberDAO.Instance.AddNew(member);
        public void DeleteMember(int memberId) => MemberDAO.Instance.Remove(memberId);
        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);
        public Boolean RegisterOrNot(string Email) => MemberDAO.Instance.RegisterOrNot(Email);
        public Member Login(string Email, string Password) => MemberDAO.Instance.MemberLogin(Email, Password);
    }
}