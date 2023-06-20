using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class ProductRepository:IProductRepository
    {
        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProductList();
        public Product GetProductById(int productId) => ProductDAO.Instance.GetProductById(productId);
        public void InsertProduct(Product product) => ProductDAO.Instance.AddNew(product);
        public void DeleteProduct(int productId) => ProductDAO.Instance.Remove(productId);
        public void UpdateProduct(Product product) => ProductDAO.Instance.Update(product);
    }
}