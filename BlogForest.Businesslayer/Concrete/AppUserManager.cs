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
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public AppUser GetAppUserInformationByBlogId(int id)
        {
            return _appUserDal.GetAppUserInformationByBlogId(id);
        }

        public AppUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AppUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
