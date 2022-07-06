﻿using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;
using SiemensECommerce.Business.Repository;
namespace SiemensECommerce.UI.Controllers
{
    public class OrderController : SiteBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OrderAdd()
        {
            return View();
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
                order.Phone = model.Phone;
                order.FirstName = model.FirstName;
                order.LastName = model.LastName;
                order.EMail = model.EMail;


                unitOfWork.OrderRepository.Add(order);
                unitOfWork.Save();

                //WebUserManager.Add(webUser);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

    }
}