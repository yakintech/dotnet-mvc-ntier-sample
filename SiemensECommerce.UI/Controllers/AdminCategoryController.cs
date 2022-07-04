using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Data.ORM;

namespace SiemensECommerce.UI.Controllers
{
    public class AdminCategoryController : AdminBaseController
    {
        public IActionResult Index(string sortOrder)
        {
            ViewBag.SortOrderParam = String.IsNullOrEmpty(sortOrder) ? "name" : null; 

            CategoryManager categoryManager = new CategoryManager();

            var categories = categoryManager.GetCategories();

            switch (sortOrder)
            {
                case "name":
                    categories = categories.OrderByDescending(c => c.Name).ToList();
                    break;
                default:
                    categories = categories.OrderBy(c => c.Name).ToList();
                    break;
            }

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

        [HttpGet]
        public IActionResult Update(int id)
        {
            //Önce update edilecek category bulunur ve ekrandaki inputlar doldurulur

            CategoryManager categoryManager = new CategoryManager();
            Category category = categoryManager.GetCategoryById(id);

            return View(category);
        }

        [HttpPost]
        public IActionResult Update(Category model)
        {
            CategoryManager categoryManager = new CategoryManager();

            categoryManager.Update(model);

            return RedirectToAction("Index");
        }

        
    }
}
