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
            //Önce update edilecek category bulunur ve ekrandaki inputlar doldurulur

            WebUserManager webUserManager = new WebUserManager();
            WebUser webUser = webUserManager.GetCategoryById(id);

            return View(webUser);
        }

        [HttpPost]
        public IActionResult Update(WebUser model)
        {
            WebUserManager webUserManager = new WebUserManager();

            webUserManager.Update(model);

            return RedirectToAction("Index");
        }





    }
}
