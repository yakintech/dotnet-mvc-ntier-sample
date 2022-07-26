using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Repository;

namespace SiemensECommerce.UI.Controllers
{
    public class CategoryController : SiteBaseController
    {
        public IActionResult Index()
        {
           

            return View();
        }
         

        [Route("Category/{name}/{id}")]
        public IActionResult Detail(string name, int id)
        {
            var work = new UnitOfWork();
            var categoryProducts = work.ProductRepository.GetAll().Where(q => q.CategoryId == id).ToList();

            return View(categoryProducts);
        }


    }
}
