using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Service;

namespace TeduShop.Web.Api
{
    public class PostCategoryController : ApiBaseController
    {
        public PostCategoryController(IErrorService errorService) : base(errorService)
        {

        }
    }
}
