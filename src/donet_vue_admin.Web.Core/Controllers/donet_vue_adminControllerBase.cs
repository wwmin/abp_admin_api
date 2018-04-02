using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace donet_vue_admin.Controllers
{
    public abstract class donet_vue_adminControllerBase: AbpController
    {
        protected donet_vue_adminControllerBase()
        {
            LocalizationSourceName = donet_vue_adminConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
