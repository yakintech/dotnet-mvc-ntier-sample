using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace SiemensECommerce.UI.Controllers
{
    [Authorize]
    public class SiteBaseController : HomeController
    {
        //Bu metot herhangi bir action çalışmadan önce ÇALIŞACAKTIR.
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var userEmail = HttpContext.User.Claims.FirstOrDefault(q => q.Type == ClaimTypes.Email)?.Value;
            ViewBag.email = userEmail;
        }
    }
}
