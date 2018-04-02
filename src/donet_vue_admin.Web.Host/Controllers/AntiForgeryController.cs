using Microsoft.AspNetCore.Antiforgery;
using donet_vue_admin.Controllers;

namespace donet_vue_admin.Web.Host.Controllers
{
    public class AntiForgeryController : donet_vue_adminControllerBase
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
