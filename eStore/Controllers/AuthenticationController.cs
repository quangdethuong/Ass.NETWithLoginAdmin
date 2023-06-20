using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace eStore.Controllers
{
    public class AuthenticationController : Controller
    {

        private readonly IConfiguration configuration;
        IMemberRepository memberRepository = null;

        public AuthenticationController(IConfiguration configuration){
            memberRepository = new MemberRepository();
            this.configuration = configuration;
        } 
        
        public IActionResult Login()
        {
            if(HttpContext.Session.GetInt32("Role") !=null){
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Member member)
        {
            if(HttpContext.Session.GetInt32("Role") !=null){
                return RedirectToAction("Index", "Home");
            }

            string adminEmail = this.configuration.GetValue<string>("Account:email");
            string adminPassword = this.configuration.GetValue<string>("Account:password");
            if (member.Email == adminEmail && member.Password == adminPassword) {
                HttpContext.Session.SetInt32("Role", 0);
                return RedirectToAction("Index", "Home");
            }
            Member tmp = memberRepository.Login(member.Email, member.Password);
            if (tmp == null) {
                ViewBag.Error = "Wrong email or password";
                return View();
            }
            HttpContext.Session.SetInt32("MemberId", tmp.MemberId);
            HttpContext.Session.SetInt32("Role", 1);
            HttpContext.Session.SetString("Email", member.Email);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("MemberId");
            HttpContext.Session.Remove("Role");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            if(HttpContext.Session.GetInt32("Role") !=null){
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Member member)
        {
            try {
                string adminEmail = this.configuration.GetValue<string>("Account:email");
                string adminPassword = this.configuration.GetValue<string>("Account:password");
            
                if (member.Email == adminEmail && member.Password == adminPassword) {
                    ViewBag.Error = "Can't register this username!";
                    return View();
                }
                if (memberRepository.RegisterOrNot(member.Email)) {
                    ViewBag.Error = "Email is valid!!!";
                    return View();
                }
                if (ModelState.IsValid) {
                    var ls = memberRepository.GetMembers();
                    member.MemberId = ls.Max(t => t.MemberId);
                    member.MemberId+=1;
                    memberRepository.InsertMember(member);
                    HttpContext.Session.SetInt32("MemberId", member.MemberId);
                    HttpContext.Session.SetInt32("Role", 1);
                    HttpContext.Session.SetString("Email", member.Email);
                    return RedirectToAction("Index", "Home");
                }
                return View();
            }
            catch (Exception ex) {
                ViewBag.Error = ex.Message;
                return View();
            }
        }
    }
}