using System.Threading.Tasks;
using Abp.Application.Services;
using TestBlazorServer.Sessions.Dto;

namespace TestBlazorServer.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
