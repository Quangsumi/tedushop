using AutoMapper;
using TeduShop.Model.Models;
using TeduShop.Web.Controllers;

namespace TeduShop.Web
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }

        public static MapperConfiguration MapperConfiguration { get; private set; }

        public static void Init()
        {
            MapperConfiguration = new MapperConfiguration(cfg =>
            {
                // Mapping domain entities to view entities
                cfg.CreateMap<PostCategory, PostCategoryDto>();
                //cfg.CreateMap<List<Category>, List<CategoryViewModel>>();

                // Mapping view entities to domain entities
                cfg.CreateMap<PostCategoryDto, PostCategory>();
                //cfg.CreateMap<TagViewModel, Tag>();
                //cfg.CreateMap<CommentViewModel, Comment>();
                //cfg.CreateMap<CategoryViewModel, Category>();
                //cfg.CreateMap<List<CategoryViewModel>, List<Category>>();
            });

            Mapper = MapperConfiguration.CreateMapper();
        }
    }
}