﻿using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;

namespace SiemensECommerce.UI.Controllers
{
    public class HomeController : SiteBaseController
    {
        public IActionResult Index()
        {
            var allProducts = new ProductManager().GetProducts();

            return View(allProducts);
        }

        public IActionResult ProductDetail()
        {
            return View();
        }
    }
}
