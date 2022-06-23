﻿using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;

namespace SiemensECommerce.UI.Controllers
{

    public class AdminUserController : AdminBaseController
    {

        public IActionResult Index()
        {
            WebUserManager webUserManager = new WebUserManager();

            var webusers = webUserManager.GetWebUsers();
            return View(webusers);
        }

        public IActionResult Add()
        {
            return View();
        }
        

        public IActionResult Delete(int id)
        {
            SupplierManager supplierManager = new SupplierManager();
            supplierManager.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
