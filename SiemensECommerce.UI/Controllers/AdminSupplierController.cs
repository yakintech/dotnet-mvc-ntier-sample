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
            //SupplierManager supplierManager = new SupplierManager();

            var suppliers = unitOfWork.SupplierRepository.GetAll();
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

                unitOfWork.SupplierRepository.Add(supplier);
                unitOfWork.Save();


                //List<Supplier> suppliers = genericRepository.GetAllWithQuery(q => q.CompanyName.Contains('a'));


                return RedirectToAction("Index");
            }
            else
                return View();
        }
        
        public IActionResult Delete(int id)
        {
            //SupplierManager supplierManager=new SupplierManager();
            //supplierManager.Delete(id);

            unitOfWork.SupplierRepository.Delete(id);
            unitOfWork.Save();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            //SupplierManager supplierManager = new SupplierManager();
            Supplier supplier = unitOfWork.SupplierRepository.GetEntityById(id);
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
