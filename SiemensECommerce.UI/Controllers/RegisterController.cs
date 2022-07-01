using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Business.Repository;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;

namespace SiemensECommerce.UI.Controllers
{
    public class RegisterController : SiteBaseController
    {
        public IActionResult Index()
        {

            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Add(WebUserVM model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        WebUser webuser1 = new WebUser();
        //        webuser1.Name = model.Name;
        //        webuser1.SurName = model.SurName;
        //        webuser1.Email = model.Email;    
        //        webuser1.Password = model.Password;
        //        webuser1.PhoneNumber = model.PhoneNumber;
        //        webuser1.IsDeleted = false;

        //        unitOfWork.WebUserRepository.Add(webuser1);
        //        unitOfWork.Save();

        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View();
        //    }


        //}
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(WebUserVM model)
        {
            if (ModelState.IsValid)
            {
                WebUser webUser1 = new WebUser();
                webUser1.Name = model.Name;
                webUser1.SurName = model.SurName;
                webUser1.Password = model.Password;
                webUser1.Email = model.Email;
                webUser1.PhoneNumber = model.PhoneNumber;
                webUser1.IsDeleted = false;

                unitOfWork.WebUserRepository.Add(webUser1);
                unitOfWork.Save();

                //WebUserManager.Add(webUser);

                return RedirectToAction("Index","Login");
            }
            else
            {
                return View();
            }
        }

    }
    }
