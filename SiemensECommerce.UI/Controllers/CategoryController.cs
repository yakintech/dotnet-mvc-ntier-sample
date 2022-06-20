using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Data.ORM;

namespace SiemensECommerce.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            CategoryManager categoryManager = new CategoryManager();
            var categories = categoryManager.GetCategories();

            return View();
        }
    }
}
