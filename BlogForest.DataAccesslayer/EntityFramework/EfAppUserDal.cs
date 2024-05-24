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
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        private readonly BlogContext _blogContext;
        public EfAppUserDal(BlogContext context) : base(context)
        {
            _blogContext = context;
        }

        public AppUser GetAppUserInformationByBlogId(int id)
        {
            var value = _blogContext.Blogs.Where(x => x.BlogId == id).Select(y => y.AppUser).FirstOrDefault();
            return value;
        }
    }
}
