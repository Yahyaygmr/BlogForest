using BlogForest.DataAccesslayer.Abstract;
using BlogForest.DataAccesslayer.Context;
using BlogForest.DataAccesslayer.Repositories;
using BlogForest.Dtolayer.CategoryDtos;
using BlogForest.Entitylayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.DataAccesslayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        private readonly BlogContext _context;
        public EfCategoryDal(BlogContext context) : base(context)
        {
            _context = context;
        }
        public List<ResultCategoryWithBlogCountDto> GetCategoryWithBlogCount()
        {
            var categories = _context.Categories
                .Include(x => x.Blogs);
            return categories.Select(x => new ResultCategoryWithBlogCountDto
            {
                CategoryId = x.CategoryId,
                Name = x.CategoryName,
                BlogCount = _context.Blogs.Count(y => y.CategoryId == x.CategoryId)
            }).ToList();
        }
    }
}
