using Abp.Authorization;
using OSMS.Authorization.Roles;
using OSMS.Authorization.Users;

namespace OSMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
