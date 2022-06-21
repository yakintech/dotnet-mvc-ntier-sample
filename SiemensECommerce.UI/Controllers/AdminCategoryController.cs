using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Data.ORM;

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

        public IActionResult Delete(int id)
        {
            CategoryManager categoryManager = new CategoryManager();
            categoryManager.Delete(id);

            return RedirectToAction("Index");
        }



        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(Category category)
        {
            CategoryManager categoryManager = new CategoryManager();
            categoryManager.Add(category);

            return RedirectToAction("Index");
            
        }

        
    }
}
