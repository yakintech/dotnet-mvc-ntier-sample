using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Repository;

namespace SiemensECommerce.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            var work = new UnitOfWork();
            var categoryProducts = work.ProductRepository.GetAll().Where(q => q.CategoryId == id).ToList();

            return View(categoryProducts);
        }
    }
}
