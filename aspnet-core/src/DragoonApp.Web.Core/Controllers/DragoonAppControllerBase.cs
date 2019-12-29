using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DragoonApp.Controllers
{
    public abstract class DragoonAppControllerBase: AbpController
    {
        protected DragoonAppControllerBase()
        {
            LocalizationSourceName = DragoonAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
