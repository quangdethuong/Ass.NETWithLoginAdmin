using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class CategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> GetCategories() => CategoryDAO.Instance.GetCatoryList();
    }
}