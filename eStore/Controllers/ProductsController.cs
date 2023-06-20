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
    public class ProductsController : Controller
    {
        
      IProductRepository productRepository = null;
      ICategoryRepository categoryRepository = null;
      public ProductsController() {
        productRepository = new ProductRepository();
        categoryRepository = new CategoryRepository();
      } 


      // GET: /<controller>/

        public IActionResult Index()
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            var prolist = productRepository.GetProducts();
            return View(prolist);
        }

         public ActionResult Details(int? id)
        { 
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            var prolist = categoryRepository.GetCategories();
            ViewBag.prolist = prolist;
            if (id == null)
            {
                return NotFound();
            }
            var product = productRepository.GetProductById(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        public ActionResult Create() {  
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            var prolist = categoryRepository.GetCategories();
            ViewBag.prolist = prolist;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            try
            {   
                if (ModelState.IsValid)
                {
                    var ls = productRepository.GetProducts();
                    product.ProductId = ls.Max(t => t.ProductId);
                    product.ProductId+=1;
                    productRepository.InsertProduct(product);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(product);
            }
        }

        public ActionResult Update(int? id)
        { 
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            var prolist = categoryRepository.GetCategories();
            ViewBag.prolist = prolist;
            if (id == null)
            {
                return NotFound();
            }
            var product = productRepository.GetProductById(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

           [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, Product product)
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            try
            {
                if (id != product.ProductId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    productRepository.UpdateProduct(product);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(product);
            }
        }

         public ActionResult Delete(int? id)
        { 
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            var prolist = categoryRepository.GetCategories();
            ViewBag.prolist = prolist;
            if (id == null)
            {
                return NotFound();
            }
            var product = productRepository.GetProductById(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            int? role = HttpContext.Session.GetInt32("Role");
            if (role == null || role.Value != 0) return RedirectToAction("Index", "Home");
            
            try
            {
                productRepository.DeleteProduct(id);
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