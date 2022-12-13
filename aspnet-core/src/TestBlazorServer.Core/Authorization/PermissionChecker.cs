using Abp.Authorization;
using TestBlazorServer.Authorization.Roles;
using TestBlazorServer.Authorization.Users;

namespace TestBlazorServer.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
