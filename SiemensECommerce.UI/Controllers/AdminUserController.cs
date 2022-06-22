using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;

namespace SiemensECommerce.UI.Controllers
{

    public class AdminUserController : AdminBaseController
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AdminUserVM model)
        {
            if (ModelState.IsValid)
            {
                //Model doğrulandıysa burada veritabanına bir AdminUser yolluyorum.

                AdminUser adminUser = new AdminUser();
                adminUser.EMail = model.EMail;
                adminUser.Password = model.Password;

                AdminUserManager.Add(adminUser);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


    }
}
