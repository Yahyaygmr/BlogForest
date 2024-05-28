using BlogForest.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.Businesslayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetBlogsWithCategoryAndUser();
        Blog GetBlogWithCategoryAndUserById(int id);
        List<Blog> GetLast2BlogByAppUser(int id);
        List<Blog> GetBlogsByAppUser(int id);
    }
}
