using Microsoft.AspNetCore.Mvc;

namespace SiemensECommerce.UI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
