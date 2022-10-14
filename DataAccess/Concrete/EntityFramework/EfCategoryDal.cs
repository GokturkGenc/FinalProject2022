using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
        public List<CategoryDetailDto> GetCategoryDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from c in context.Categories
                             join p in context.Products
                             on c.CategoryId equals p.CategoryId
                             select new CategoryDetailDto
                             {
                                 CategoryId = c.CategoryId,
                                 CategoryName = c.CategoryName,
                             };
                return result.ToList();

            }
        }
    }
}
