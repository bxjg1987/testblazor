using Abp.Application.Services;
using TestBlazorServer.MultiTenancy.Dto;

namespace TestBlazorServer.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

