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
            var count = _postCategoryService.GetAll().Count();

            return Content(count.ToString());
        }
    }
}