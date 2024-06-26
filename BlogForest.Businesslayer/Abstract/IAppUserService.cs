﻿using BlogForest.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.Businesslayer.Abstract
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        AppUser GetAppUserInformationByBlogId(int id);
    }
}
