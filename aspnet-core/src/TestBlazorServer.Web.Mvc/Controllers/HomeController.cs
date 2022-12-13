using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TestBlazorServer.Controllers;

namespace TestBlazorServer.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TestBlazorServerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestBlazor()
        {
            return View();

        }
    }
}
