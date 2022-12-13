using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestBlazorServer.Configuration;

namespace TestBlazorServer.Web.Host.Startup
{
    [DependsOn(
       typeof(TestBlazorServerWebCoreModule))]
    public class TestBlazorServerWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TestBlazorServerWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestBlazorServerWebHostModule).GetAssembly());
        }
    }
}
