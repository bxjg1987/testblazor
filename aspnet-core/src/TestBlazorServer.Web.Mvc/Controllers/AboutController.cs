using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TestBlazorServer.Controllers;

namespace TestBlazorServer.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : TestBlazorServerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
