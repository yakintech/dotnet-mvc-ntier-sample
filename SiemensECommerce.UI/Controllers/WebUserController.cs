using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Business.Repository;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;

namespace SiemensECommerce.UI.Controllers
{
    public class WebUserController : AdminBaseController
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


                unitOfWork.WebUserRepository.Add(webUser);
                unitOfWork.Save();

                //WebUserManager.Add(webUser);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


        public IActionResult Search(string query)
        {
            WebUserManager webUserManager = new WebUserManager();
            var webUsers = webUserManager.GetWebUsers().Where(q => q.Name.ToLower().Contains(query.ToLower()));
            return View("Index", webUsers.ToList());

        }

        
    }
}
