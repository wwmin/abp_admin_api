using Abp.Authorization;
using donet_vue_admin.Authorization.Roles;
using donet_vue_admin.Authorization.Users;

namespace donet_vue_admin.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
