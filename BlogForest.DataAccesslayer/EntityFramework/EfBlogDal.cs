using BlogForest.DataAccesslayer.Abstract;
using BlogForest.DataAccesslayer.Context;
using BlogForest.DataAccesslayer.Repositories;
using BlogForest.Entitylayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.DataAccesslayer.EntityFramework
{
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
        private readonly BlogContext _context;
        public EfBlogDal(BlogContext context) : base(context)
        {
            _context = context;
        }

        public List<Blog> GetBlogsByAppUser(int id)
        {
            var values = _context.Blogs
               .Where(x => x.AppUserId == id)
               .Include(x => x.Category)
               .ToList();
            return values;
        }

        public List<Blog> GetBlogsWithCategoryAndUser()
        {
            return _context.Blogs
                .Include(x => x.Category)
                .Include(x => x.AppUser)
                .ToList();
        }

        public Blog? GetBlogWithCategoryAndUserById(int id)
        {
            return _context.Blogs
                .Where(x => x.BlogId == id)
               .Include(x => x.Category)
               .Include(x => x.AppUser)
               .FirstOrDefault();

        }

        public List<Blog> GetLast2BlogByAppUser(int id)
        {
            var values = _context.Blogs
                .Where(x => x.AppUserId == id)
                .OrderByDescending(x => x.BlogId)
                .Take(2)
                .Include (x => x.Category)
                .ToList();
            return values;
        }
    }
}
