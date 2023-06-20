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
    public class OrderDetailController : Controller {
        IOrderDetailRepository orderdetailRepository = null;
        public OrderDetailController() => orderdetailRepository = new OrderDetailRepository();
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int OrderId, int ProductId, decimal UnitPrice, int Quantity, double Discount) {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            try
            {
                OrderDetail orderdetail = new OrderDetail(OrderId, ProductId, UnitPrice, Quantity, Discount);
                if (ModelState.IsValid)
                {
                    orderdetailRepository.InsertOrderDetail(orderdetail);
                }
                return RedirectToAction("Detail", "Order", new {id = OrderId});
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return RedirectToAction("Detail", "Order", new {id =OrderId});
            }
        }

        public ActionResult Update(int? id, int? product_id)
        { 
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            var ordelist = orderdetailRepository.GetOrderDetails();
            ViewBag.ordelist = ordelist;
            if (id == null || product_id == null)
            {
                return NotFound();
            }
            var order = orderdetailRepository.GetOrderDetailById(product_id.Value, id.Value);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(OrderDetail orderDetail)
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            try
            {
                if (ModelState.IsValid)
                {
                    orderdetailRepository.UpdateOrderDetail(orderDetail);
                }
                return RedirectToAction("Detail", "Order", new { id = orderDetail.OrderId });
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(orderDetail);
            }
        }

        public IActionResult DeleteDetail(int? id, int? product_id)
        { 
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            try
            {
                orderdetailRepository.DeleteOrderDetail(product_id.Value, id.Value);
                return RedirectToAction("Detail", "Order", new {id = id});
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return RedirectToAction("Detail", "Order", new {id = id});
            }
        }
    }
}