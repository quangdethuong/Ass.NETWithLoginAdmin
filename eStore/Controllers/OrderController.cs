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
    public class OrderController : Controller {
        IOrderRepository orderRepository = null;
        IMemberRepository memberRepository = null;
        IProductRepository productRepository = null;
        public OrderController() {
            orderRepository = new OrderRepository();
            memberRepository = new MemberRepository();
            productRepository = new ProductRepository();
        } 
        // GET: /<controller>/
        public IActionResult Index()
        {   
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            var orderList = orderRepository.GetOrders();
            ViewBag.orderList = orderList;
            return View(orderList);
        }
        public ActionResult Edit(int? id)
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            var memlist = memberRepository.GetMembers();
            ViewBag.memlist = memlist;
            if (id == null)
            {
                return NotFound();
            }
            var order = orderRepository.GetOrderById(id.Value);
            if (order == null) {
                return NotFound();
            }
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Order order)
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            try
            {
                if (id != order.OrderId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    orderRepository.UpdateOrder(order);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(order);
            }
        }
        public ActionResult Create() {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
             var memlist = memberRepository.GetMembers();
            ViewBag.memlist = memlist;
            return View();
        } 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order order) {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            try
            {
                if (ModelState.IsValid)
                {
                    var listOrder = orderRepository.GetOrders();
                    order.OrderId = listOrder.Max(c => c.OrderId);
                    order.OrderId+=1;
                    orderRepository.InsertOrder(order);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(order);
            }
        }

        
        public ActionResult Detail(int? id)
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            

            if (id == null)
            {
                return NotFound();
            }
            var order = orderRepository.GetOrderById(id.Value);
            var productList = productRepository.GetProducts();
            var listordetailPid = order.OrderDetails;
            foreach (var item in productList)
            {
                var fi = listordetailPid.Where(c => c.ProductId == item.ProductId).ToList();
                if (fi.Count != 0) item.ProductId = -1; 
            }
            ViewBag.productList = productList;
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }
        public IActionResult Report(DateTime StartDate, DateTime EndDate)
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            

            var orderList = orderRepository.GetOrders();
            List<Order> finalList = new List<Order>();
            foreach(var  i in orderList) {
                if(i.OrderDate>= StartDate &&  i.OrderDate<= EndDate ){
                    finalList.Add(i);
                }
            }
            
            return View(finalList.OrderBy(x => x.Freight).Reverse());
        }

         public ActionResult Delete(int? id)
        { 
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            if (id == null)
            {
                return NotFound();
            }
            var order = orderRepository.GetOrderById(id.Value);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            try
            {
                orderRepository.DeleteOrder(id);
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