using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace TestBlazorServer.Web.Views
{
    public abstract class TestBlazorServerRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TestBlazorServerRazorPage()
        {
            LocalizationSourceName = TestBlazorServerConsts.LocalizationSourceName;
        }
    }
}
