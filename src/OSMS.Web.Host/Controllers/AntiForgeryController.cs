using Microsoft.AspNetCore.Antiforgery;
using OSMS.Controllers;

namespace OSMS.Web.Host.Controllers
{
    public class AntiForgeryController : OSMSControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
