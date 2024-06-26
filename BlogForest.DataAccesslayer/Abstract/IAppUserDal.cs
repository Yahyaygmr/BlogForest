﻿using BlogForest.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.DataAccesslayer.Abstract
{
    public interface IAppUserDal : IGenericDal<AppUser>
    {
        AppUser GetAppUserInformationByBlogId(int id);
    }
}
