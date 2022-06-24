using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;

namespace SiemensECommerce.UI.Controllers
{
    public class WebUserController : Controller
    {
        public IActionResult Index()
        {
            WebUserManager webUserManager = new WebUserManager();

            var webUsers = webUserManager.GetWebUsers();
            return View(webUsers);
        }

        public IActionResult Delete(int id)
        {
            WebUserManager webUserManager = new WebUserManager();
            webUserManager.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            WebUserManager webUserManager = new WebUserManager();
            WebUser webUser = webUserManager.GetUserById(id);

            return View(webUser);
        }

        [HttpPost]
        public IActionResult Update(WebUser model)
        {
            WebUserManager webUserManager = new WebUserManager();

            webUserManager.Update(model);

            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
      public IActionResult Add(WebUserVM model)
        {
            if (ModelState.IsValid)
            {
                WebUser webUser = new WebUser();
                webUser.Name = model.Name;
                webUser.SurName = model.SurName;
                webUser.Password = model.Password;
                webUser.Email = model.Email;    
                webUser.PhoneNumber = model.PhoneNumber;

                WebUserManager.Add(webUser);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


    }
}
