using System.Collections.Generic;
using TestBlazorServer.Roles.Dto;

namespace TestBlazorServer.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}