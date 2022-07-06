using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;
using SiemensECommerce.Business.Repository;
namespace SiemensECommerce.UI.Controllers
{
    public class ContactController : SiteBaseController
    {
        public IActionResult Index()
        {
            return View();
            
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ContactVM model)
        {
            if (ModelState.IsValid)
            {
                Contact contact = new Contact();
                contact.Name = model.Name;
                contact.Surname = model.Surname;
                contact.Phone = model.Phone;
                contact.Email = model.Email;
                contact.Message = model.Message;

                unitOfWork.contactRepsitory.Add(contact);
                unitOfWork.Save();

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
