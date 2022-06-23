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

       
           
        
       
      
     
    }
}
