using Abp.Application.Services.Dto;

namespace TestBlazorServer.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

