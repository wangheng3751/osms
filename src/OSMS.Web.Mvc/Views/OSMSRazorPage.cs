using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace OSMS.Web.Views
{
    public abstract class OSMSRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected OSMSRazorPage()
        {
            LocalizationSourceName = OSMSConsts.LocalizationSourceName;
        }
    }
}
