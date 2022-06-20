using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Data.ORM;

namespace SiemensECommerce.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            SiemensECommerceContext db = new SiemensECommerceContext();

            var categories = db.Categories.ToList();
            return View();
        }
    }
}
