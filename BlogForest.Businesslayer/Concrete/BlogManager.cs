using BlogForest.Businesslayer.Abstract;
using BlogForest.DataAccesslayer.Abstract;
using BlogForest.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.Businesslayer.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Delete(int id)
        {
            _blogDal.Delete(id);
        }

        public List<Blog> GetBlogsWithCategoryAndUser()
        {
            return _blogDal.GetBlogsWithCategoryAndUser();
        }

        public Blog GetBlogWithCategoryAndUserById(int id)
        {
            return _blogDal.GetBlogWithCategoryAndUserById(id);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetLast2BlogByAppUser(int id)
        {
            return _blogDal.GetLast2BlogByAppUser(id);
        }

        public List<Blog> GetListAll()
        {
            return _blogDal.GetListAll();
        }

        public void Insert(Blog entity)
        {
            _blogDal.Insert(entity);
        }

        public void Update(Blog entity)
        {
            _blogDal.Update(entity);
        }
    }
}
