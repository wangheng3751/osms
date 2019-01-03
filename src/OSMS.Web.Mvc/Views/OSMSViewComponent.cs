using Abp.AspNetCore.Mvc.ViewComponents;

namespace OSMS.Web.Views
{
    public abstract class OSMSViewComponent : AbpViewComponent
    {
        protected OSMSViewComponent()
        {
            LocalizationSourceName = OSMSConsts.LocalizationSourceName;
        }
    }
}
