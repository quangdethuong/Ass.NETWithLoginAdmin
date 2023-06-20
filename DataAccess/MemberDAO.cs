using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new Object();
        public static MemberDAO Instance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Member> GetMemberList()
        {
            var members = new List<Member>();
            try
            {
                using var context = new ASSIGNMENT1Context();
                members = context.Members.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }


        public Member GetMemberById(int MemberId)
        {
            Member member = null;
            try
            {
                using var context = new ASSIGNMENT1Context();
                member = context.Members.SingleOrDefault(c => c.MemberId == MemberId);
                if (member != null) {
                    var e = context.Entry(member);
                    e.Collection(c => c.Orders).Load();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }

        public Member MemberLogin(string Email, string Password) {
            try {
                using var context = new ASSIGNMENT1Context();
                var member = from Member in context.Members 
                    where Member.Email == Email 
                    where Member.Password == Password 
                    select Member;
                if (member == null) {
                    return null;
                }
                return member.FirstOrDefault();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public void AddNew(Member member)
        {
            try
            {
                Member _member = GetMemberById(member.MemberId);
                if (_member == null)
                {
                    using var context = new ASSIGNMENT1Context();
                    context.Members.Add(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The member is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Member member)
        {
            try
            {
                Member _member = GetMemberById(member.MemberId);
                if (_member != null)
                {
                    using var context = new ASSIGNMENT1Context();
                    context.Members.Update(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The member does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int memberId)
        {
            try
            {
                Member member = GetMemberById(memberId);
                if (member != null)
                {
                    using var context = new ASSIGNMENT1Context();
                    context.Members.Remove(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The member does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean RegisterOrNot(string Email) {
            Member member = null;
            try
            {
                using var context = new ASSIGNMENT1Context();
                member = context.Members.SingleOrDefault(c => c.Email == Email);
                if (member != null) {
                    var e = context.Entry(member);
                    e.Collection(c => c.Orders).Load();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}