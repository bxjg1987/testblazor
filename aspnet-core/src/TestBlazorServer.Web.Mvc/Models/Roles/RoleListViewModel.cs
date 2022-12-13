using System.Collections.Generic;
using TestBlazorServer.Roles.Dto;

namespace TestBlazorServer.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
