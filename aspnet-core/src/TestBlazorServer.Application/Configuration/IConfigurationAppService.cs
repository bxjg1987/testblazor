using System.Threading.Tasks;
using TestBlazorServer.Configuration.Dto;

namespace TestBlazorServer.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
