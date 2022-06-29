using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Data.ORM;
using System.Linq;
//using BMS;

namespace SiemensECommerce.UI.Controllers
{
    public class ForgotPasswordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    [HttpPost]
    public IActionResult forgot(string email)
    {
         var adminUser = new AdminUserManager().GetAdminUsers().First(q => q.EMail == email);
         var fpManager = new ForgotPasswordManager();

         if(adminUser == null)
         {
            return View();
         }
        
        var fp = new ForgotPassword();
        fp.AdminUser= adminUser;
        fp.Token = new Guid().ToString();
        fp.ExpiredDate = DateTime.Now.AddDays(1);
        fpManager.Add(fp);


        return View();
    }

    }
}
