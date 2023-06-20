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
    public class AccountController : Controller
    {
        IMemberRepository memberRepository = null;
        IOrderRepository orderRepository = null;
        public AccountController() {
            memberRepository = new MemberRepository();
            orderRepository = new OrderRepository();
        } 

        public IActionResult Index()
        {
            int? memberId = HttpContext.Session.GetInt32("MemberId");
            if (memberId == null) return RedirectToAction("Index", "Home");
            var member = memberRepository.GetMemberById(memberId.Value);
            return View(member);
        }
        
        public ActionResult Edit()
        {
            int? memberId = HttpContext.Session.GetInt32("MemberId");
            if (memberId == null) return RedirectToAction("Index", "Home");
            var member = memberRepository.GetMemberById(memberId.Value);
            return View(member);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Member member)
        {
            int? memberId = HttpContext.Session.GetInt32("MemberId");
            if (memberId == null) return RedirectToAction("Index", "Home");
            var _member = memberRepository.GetMemberById(memberId.Value);
            member.Password = _member.Password;
            try
            {
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

        public IActionResult ChangePassword()
        {
            int? memberId = HttpContext.Session.GetInt32("MemberId");
            if (memberId == null) return RedirectToAction("Index", "Home");
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword(string OldPass, string NewPass, string NewPassRepeat)
        {
            int? memberId = HttpContext.Session.GetInt32("MemberId");
            if (memberId == null) return RedirectToAction("Index", "Home");
            var _member = memberRepository.GetMemberById(memberId.Value);
            if (OldPass != _member.Password) {
                ViewBag.errorOld = "Wrong password";
                return View();
            }
            if (NewPass != NewPassRepeat) {
                ViewBag.errorRepeat = "Wrong repeat password";
                return View();
            }
            _member.Password = NewPass;
            memberRepository.UpdateMember(_member);
            return RedirectToAction("Index");
        }

        public IActionResult HistoryOrder()
        {
            int? memberId = HttpContext.Session.GetInt32("MemberId");
            if (memberId == null) return RedirectToAction("Index", "Home");
            var ls = orderRepository.GetOrders();
            var lsRes = new List<Order>();
            foreach (var item in ls)
            {
                if (item.MemberId == memberId.Value) lsRes.Add(item);
            }
            return View((IEnumerable<Order>)lsRes);
        }
        
        public IActionResult DetailsOrder(int? id)
        {
            int? memberId = HttpContext.Session.GetInt32("MemberId");
            if (memberId == null) return RedirectToAction("Index", "Home");
            if (id == null) {
                return NotFound();
            }
            var res = orderRepository.GetOrderById(id.Value);
            if (res.MemberId != memberId.Value) return RedirectToAction("Index");

            return View(res.OrderDetails);
        }
        
    }
}