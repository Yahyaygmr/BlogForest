﻿using BlogForest.Dtolayer.CategoryDtos;
using BlogForest.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.Businesslayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        List<ResultCategoryWithBlogCountDto> GetCategoryWithBlogCount();
    }
}
