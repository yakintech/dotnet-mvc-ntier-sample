using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;
using SiemensECommerce.Business.Repository;
namespace SiemensECommerce.UI.Controllers
{
    public class OrderController : SiteBaseController
    {
        public IActionResult Index()
        {
            var orders = unitOfWork.OrderRepository.GetAll();
            var webusers = unitOfWork.WebUserRepository.GetAll();

            return View(orders);

        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(OrderVM model)
        {
            if (ModelState.IsValid)
            {
                Order order = new Order();
                order.Adress = model.Adress;
                order.WebUser.PhoneNumber = model.WebUser.PhoneNumber;
                order.WebUser.Name = model.WebUser.Name;
                order.WebUser.SurName = model.WebUser.SurName;
                order.WebUser.Email = model.WebUser.Email;

                unitOfWork.OrderRepository.Add(order);
                unitOfWork.Save();

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

    }
}
