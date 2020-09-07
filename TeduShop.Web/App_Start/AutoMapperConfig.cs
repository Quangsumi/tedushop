using AutoMapper;
using System.Collections.Generic;
using TeduShop.Model.Models;
using TeduShop.Web.Controllers;
using TeduShop.Web.ViewModels;

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
                cfg.CreateMap<Product, ProductViewModel>();
                cfg.CreateMap<ProductCategory, ProductCategoryViewModel>();
                //cfg.CreateMap<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>();
                //cfg.CreateMap<List<Category>, List<CategoryViewModel>>();

                // Mapping view entities to domain entities
                cfg.CreateMap<PostCategoryDto, PostCategory>();
                cfg.CreateMap<ProductViewModel, Product>();
                cfg.CreateMap<ProductCategoryViewModel, ProductCategory>();
                //cfg.CreateMap<IEnumerable<ProductCategoryViewModel>, IEnumerable<ProductCategory>>();
                //cfg.CreateMap<TagViewModel, Tag>();
                //cfg.CreateMap<CommentViewModel, Comment>();
                //cfg.CreateMap<CategoryViewModel, Category>();
                //cfg.CreateMap<List<CategoryViewModel>, List<Category>>();
            });

            Mapper = MapperConfiguration.CreateMapper();
        }
    }
}