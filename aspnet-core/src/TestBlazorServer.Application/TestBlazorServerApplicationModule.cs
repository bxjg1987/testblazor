using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestBlazorServer.Authorization;

namespace TestBlazorServer
{
    [DependsOn(
        typeof(TestBlazorServerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TestBlazorServerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TestBlazorServerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TestBlazorServerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
