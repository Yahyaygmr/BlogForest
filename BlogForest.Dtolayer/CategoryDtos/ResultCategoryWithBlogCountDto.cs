using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.Dtolayer.CategoryDtos
{
    public class ResultCategoryWithBlogCountDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int BlogCount { get; set; }
    }
}
