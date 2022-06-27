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
            AdminUserManager adminUserManager = new AdminUserManager();

            var adminusers = adminUserManager.GetAdminUsers();
            return View(adminusers);
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
                AdminUser adminUser = new AdminUser();
                adminUser.EMail = model.EMail;
                adminUser.Password = model.Password;

                AdminUserManager.Add(adminUser);

                return RedirectToAction("Index");
            }

            else
                return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            AdminUserManager adminUserManager = new AdminUserManager();
            AdminUser adminUser = adminUserManager.GetUserById(id);
            AdminUserVM model = new AdminUserVM();
            model.EMail = adminUser.EMail;
            model.Password = adminUser.Password;

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(AdminUserVM model)
        {
            if (ModelState.IsValid)
            {
                AdminUserManager adminUserManager = new AdminUserManager();

                AdminUser adminUser = new AdminUser();
                adminUser.EMail = model.EMail;
                adminUser.Password = model.Password;

                adminUserManager.Update(adminUser);

                return RedirectToAction("Index");
            }
            return View();
        }



        public IActionResult Delete(int id)
        {
            SupplierManager supplierManager = new SupplierManager();
            supplierManager.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
