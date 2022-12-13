using Abp.AutoMapper;
using TestBlazorServer.Roles.Dto;
using TestBlazorServer.Web.Models.Common;

namespace TestBlazorServer.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
