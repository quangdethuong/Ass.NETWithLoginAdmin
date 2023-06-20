using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new Object();
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Product> GetProductList()
        {
            var products = new List<Product>();
            try
            {
                using var context = new ASSIGNMENT1Context();
                products = context.Products.ToList();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }


        public Product GetProductById(int ProductId)
        {
            Product product = null;
            try
            {
                using var context = new ASSIGNMENT1Context();
                product = context.Products.SingleOrDefault(c => c.ProductId == ProductId);
                if(product != null){
                var e = context.Entry(product);
                e.Collection(c => c.OrderDetails).Load();
                e.Reference(p => p.Category).Load();
                }
              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public void AddNew(Product product)
        {
            try
            {
                Product _product = GetProductById(product.ProductId);
                if (_product == null)
                {
                    using var context = new ASSIGNMENT1Context();
                    context.Products.Add(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The product is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Product product)
        {
            try
            {
                Product _product = GetProductById(product.ProductId);
                if (_product != null)
                {
                    using var context = new ASSIGNMENT1Context();
                    context.Products.Update(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The product does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int ProductId)
        {
            try
            {
                Product product = GetProductById(ProductId);
                if (product != null)
                {
                    using var context = new ASSIGNMENT1Context();
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The product does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}