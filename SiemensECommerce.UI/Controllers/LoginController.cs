using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using System.Security.Claims;

namespace SiemensECommerce.UI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(string email, string password)
        {
            bool adminControl = AdminUserManager.LoginControl(email, password);

            if (adminControl)
            {

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, email)
                 };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);


                return RedirectToAction("Index", "AdminHome");
            }
            else
            {
                return View();
            }
        }



        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(
       CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Login");
        }


    }
}
