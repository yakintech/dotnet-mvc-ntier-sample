using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Business.Repository;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;

namespace SiemensECommerce.UI.Controllers
{
    public class AdminSupplierController : AdminBaseController
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

                GenericRepository<Supplier> genericRepository = new GenericRepository<Supplier>();
                genericRepository.Add(supplier);


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

        [HttpGet]
        public IActionResult Update(int id)
        {
            SupplierManager supplierManager = new SupplierManager();
            Supplier supplier = supplierManager.GetSupplierById(id);
            return View(supplier);
        }

        [HttpPost]
        public IActionResult Update(Supplier supplier)
        {
            SupplierManager supplierManager = new SupplierManager();
            supplierManager.Update(supplier);
            return RedirectToAction("Index");
        }
    }
}
