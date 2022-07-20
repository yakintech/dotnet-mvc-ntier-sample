using Microsoft.AspNetCore.Mvc;

namespace SiemensECommerce.UI.Controllers
{
    public class AdminContactController : AdminBaseController
    {
        public IActionResult Index()
        {
            var contacts = unitOfWork.ContactRepository.GetAll();   
            return View(contacts);
        }
        public IActionResult Delete(int id)
        {
            unitOfWork.ContactRepository.Delete(id);
            unitOfWork.Save();
            return RedirectToAction("Index");   
        }
    }
}
