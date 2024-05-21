using BlogForest.DataAccesslayer.Abstract;
using BlogForest.DataAccesslayer.Context;
using BlogForest.DataAccesslayer.Repositories;
using BlogForest.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.DataAccesslayer.EntityFramework
{
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
        public EfBlogDal(BlogContext context) : base(context)
        {
        }
    }
}
