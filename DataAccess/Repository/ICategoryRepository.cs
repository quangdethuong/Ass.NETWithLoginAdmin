using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
    }
}