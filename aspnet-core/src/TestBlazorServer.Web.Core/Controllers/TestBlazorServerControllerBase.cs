using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TestBlazorServer.Controllers
{
    public abstract class TestBlazorServerControllerBase: AbpController
    {
        protected TestBlazorServerControllerBase()
        {
            LocalizationSourceName = TestBlazorServerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
