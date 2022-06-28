using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;

namespace SiemensECommerce.UI.Controllers
{
    public class AdminBrandController : AdminBaseController
    {
        public IActionResult Index()
        {
            BrandManager manager = new BrandManager();
            var brands = manager.GetBrands();
            return View(brands);
        }

       
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(BrandVM model)
        {
            if (ModelState.IsValid)
            {

                string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/brand");
                var imageFileName = model.logoImage.FileName;
                string ImagePath = Guid.NewGuid().ToString() + "_" + imageFileName;
                string filePath = Path.Combine(uploadsFolder, ImagePath);
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    await model.logoImage.CopyToAsync(fs);
                }

                Brand brand = new Brand();
                brand.Name = model.Name;
                brand.Country = model.Country;
                brand.Address = model.Address;
                brand.LogoImage = ImagePath;
               

                BrandManager.Add(brand);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Delete(int id)
        {
            BrandManager brandManager = new BrandManager();
            brandManager.Delete(id);

            return RedirectToAction("Index");
        }

    }
}
