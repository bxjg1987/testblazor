using Abp.AspNetCore.Mvc.ViewComponents;

namespace TestBlazorServer.Web.Views
{
    public abstract class TestBlazorServerViewComponent : AbpViewComponent
    {
        protected TestBlazorServerViewComponent()
        {
            LocalizationSourceName = TestBlazorServerConsts.LocalizationSourceName;
        }
    }
}
