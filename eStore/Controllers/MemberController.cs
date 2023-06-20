using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eStore.Controllers
{
   
    public class MemberController : Controller
    {
      IMemberRepository memberRepository = null;
      public MemberController() => memberRepository = new MemberRepository();
        // GET: /<controller>/
        public IActionResult Index()
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            var memberList = memberRepository.GetMembers();
            return View(memberList);
        }  
        public ActionResult Details(int? id)
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            if (id == null)
            {
                return NotFound();
            }
            var mem = memberRepository.GetMemberById(id.Value);
            if (mem == null)
            {
                return NotFound();
            }
            return View(mem);
        }
        public ActionResult Create() {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            if (memberRepository.RegisterOrNot(member.Email)) {
                ViewBag.Message = "Email have existed!";
                return View();
            }
            try
            {
                if (ModelState.IsValid)
                {
                    memberRepository.InsertMember(member);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(member);
            }
        }
        public ActionResult Edit(int? id)
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            

            if (id == null)
            {
                return NotFound();
            }
            var mem = memberRepository.GetMemberById(id.Value);
            if (mem == null)
            {
                return NotFound();
            }
            return View(mem);
        }
          [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Member member)
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            

            try
            {
                if (id != member.MemberId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    memberRepository.UpdateMember(member);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(member);
            }
        }
        public ActionResult Delete(int? id)
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            

            if (id == null)
            {
                return NotFound();
            }
            var mem = memberRepository.GetMemberById(id.Value);
            if (mem == null)
            {
                return NotFound();
            }
            return View(mem);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            

            try
            {
                memberRepository.DeleteMember(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
        
        
          }
}