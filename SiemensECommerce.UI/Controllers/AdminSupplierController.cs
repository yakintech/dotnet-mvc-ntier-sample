using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;

namespace SiemensECommerce.UI.Controllers
{
    public class AdminSupplierController : Controller
    {
        public IActionResult Index()
        {
            SupplierManager supplierManager = new SupplierManager();

            var suppliers = supplierManager.GetSuppliers();
            return View(suppliers);
        }

        public IActionResult Add() { 
            return View(); 
        }
        [HttpPost]
        public IActionResult Add(SupplierVM supplierVM)
        {
            if (ModelState.IsValid)
            {
                Supplier supplier = new Supplier();
                supplier.CompanyName = supplierVM.CompanyName;
                supplier.ContactName = supplierVM.ContactName;
                supplier.Address = supplierVM.Address;
                supplier.ContactTitle = supplierVM.ContactTitle;
                supplier.Country = supplierVM.Country;

                SupplierManager.Add(supplier);

                return RedirectToAction("Index");
            }
            else
                return View();
        }
        
        public IActionResult Delete(int id)
        {
            SupplierManager supplierManager=new SupplierManager();
            supplierManager.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
