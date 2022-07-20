using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;

namespace SiemensECommerce.UI.Controllers
{
    public class CargoController : AdminBaseController
    {
        public IActionResult Index()
        {
            var cargo = unitOfWork.CargoRepository.GetAll();
            return View(cargo);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CargoVM model)
        {
            if (ModelState.IsValid)
            {
                Cargo cargo = new Cargo();
                cargo.Name= model.Name;
                cargo.Description = model.Description;

                unitOfWork.CargoRepository.Add(cargo);
                unitOfWork.Save();

                return RedirectToAction("Add");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Update(int id)
        {
            Cargo cargo = unitOfWork.CargoRepository.GetEntityById(id);
            return View(cargo);
        }

        public IActionResult Delete(int id)
        {
            unitOfWork.CargoRepository.Delete(id);
            unitOfWork.Save();

            return RedirectToAction("Index");
        }
    }
}
