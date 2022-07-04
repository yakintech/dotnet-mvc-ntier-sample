using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Business.Repository;
using SiemensECommerce.UI.Models.VM;

namespace SiemensECommerce.UI.Controllers
{
    public class HomeController : SiteBaseController
    {
        public IActionResult Index()
        {
            var allProducts = new ProductManager().GetProducts();

            return View(allProducts);
        }

        public IActionResult ProductDetail(int id)
        {
            var productId = unitOfWork.ProductRepository.GetEntityByIdQuery(id).Include(q => q.Category).FirstOrDefault();
            return View(productId);
        }
    }
}
