using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TestBlazorServer.Configuration.Dto;

namespace TestBlazorServer.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TestBlazorServerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
