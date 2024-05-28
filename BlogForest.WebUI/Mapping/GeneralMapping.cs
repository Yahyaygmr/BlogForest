using AutoMapper;
using BlogForest.Dtolayer.BlogDtos;
using BlogForest.Entitylayer.Concrete;

namespace BlogForest.WebUI.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Blog,CreateBlogDto>().ReverseMap();
        }
    }
}
