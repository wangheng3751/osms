using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using OSMS.Controllers;

namespace OSMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : OSMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
