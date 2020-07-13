using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeduShop.Model.Models;
using TeduShop.Service;

namespace TeduShop.Web.Controllers
{
    public class PostCategoryController : Controller
    {
        IPostCategoryService _postCategoryService;

        public PostCategoryController(IPostCategoryService postCategoryService)
        {
            _postCategoryService = postCategoryService;
        }

        public ActionResult Index()
        {
            var model = _postCategoryService.GetAll().ElementAt(0);

            var dto = new PostCategoryDto();

            AutoMapperConfig.Mapper.Map(model, dto);

            var cnt = $"Id: {dto.Id}, Name: {dto.Name}, Alias: {dto.Alias}, Description: {dto.Description}, Status: {dto.Status}";

            return Content(cnt);
        }
    }

    public class PostCategoryDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }

        public string Description { get; set; }

        public bool Status { get; set; }
    }
}