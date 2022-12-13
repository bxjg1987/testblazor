using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestBlazorServer.Configuration;

namespace TestBlazorServer.Web.Startup
{
    [DependsOn(typeof(TestBlazorServerWebCoreModule))]
    public class TestBlazorServerWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TestBlazorServerWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<TestBlazorServerNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestBlazorServerWebMvcModule).GetAssembly());
        }
    }
}
