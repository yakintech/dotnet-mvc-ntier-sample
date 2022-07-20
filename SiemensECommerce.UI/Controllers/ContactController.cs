using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;
using SiemensECommerce.Business.Repository;
namespace SiemensECommerce.UI.Controllers
{
    public class ContactController : SiteBaseController
    {

        //[Route("iletisim")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactVM model)
        {
            if (ModelState.IsValid)
            {
                Contact contact1 = new Contact();
                contact1.Name = model.Name;
                contact1.Surname = model.Surname;
                contact1.Phone = model.Phone;
                contact1.Email = model.Email;
                contact1.Message = model.Message;
                contact1.AddDate = DateTime.Now;

                unitOfWork.ContactRepository.Add(contact1);
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
