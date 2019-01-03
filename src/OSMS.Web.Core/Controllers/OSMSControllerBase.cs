using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace OSMS.Controllers
{
    public abstract class OSMSControllerBase: AbpController
    {
        protected OSMSControllerBase()
        {
            LocalizationSourceName = OSMSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
