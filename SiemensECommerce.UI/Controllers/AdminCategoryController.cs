using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;

namespace SiemensECommerce.UI.Controllers
{
    public class AdminCategoryController : Controller
    {
        public IActionResult Index()
        {
            CategoryManager categoryManager = new CategoryManager();

            var categories = categoryManager.GetCategories();


            return View(categories);
        }
    }
}
