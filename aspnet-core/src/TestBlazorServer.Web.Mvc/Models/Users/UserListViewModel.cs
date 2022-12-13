using System.Collections.Generic;
using TestBlazorServer.Roles.Dto;

namespace TestBlazorServer.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
