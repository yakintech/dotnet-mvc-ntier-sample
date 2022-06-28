using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;

namespace SiemensECommerce.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allCategories = new CategoryManager().GetCategories();

            return View(allCategories);
        }
    }
}
