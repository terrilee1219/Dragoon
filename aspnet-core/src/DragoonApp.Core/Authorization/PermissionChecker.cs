using Abp.Authorization;
using DragoonApp.Authorization.Roles;
using DragoonApp.Authorization.Users;

namespace DragoonApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
