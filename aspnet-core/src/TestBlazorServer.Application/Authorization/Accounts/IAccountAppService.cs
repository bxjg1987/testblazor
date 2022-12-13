using System.Threading.Tasks;
using Abp.Application.Services;
using TestBlazorServer.Authorization.Accounts.Dto;

namespace TestBlazorServer.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
