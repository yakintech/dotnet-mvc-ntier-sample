using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Data.ORM;

namespace SiemensECommerce.UI.Controllers
{
    public class AdminProductController : AdminBaseController
    {
        public IActionResult Add()
        {
            CategoryManager categoryManager = new CategoryManager();
            List<Category> categories = categoryManager.GetCategories();
            return View(categories);
        }
    }
}
