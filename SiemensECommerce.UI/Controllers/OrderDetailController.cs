using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.UI.Models.VM;
using SiemensECommerce.Data.ORM;


namespace SiemensECommerce.UI.Controllers
{
    public class OrderDetailController : SiteBaseController
    {
        public IActionResult Index(int id)
        {

            var orderDetail = unitOfWork.OrderDetailRepository.GetAll();
            var product = unitOfWork.ProductRepository.GetAll();
            var category = unitOfWork.CategoryRepository.GetAll();
            orderDetail.Where(x => x.Id == id); 
      
            return View(orderDetail);
        }
    }
}
