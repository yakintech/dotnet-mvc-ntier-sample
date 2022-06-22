using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;

namespace SiemensECommerce.UI.Controllers
{
    public class AdminProductController : AdminBaseController
    {
        public IActionResult Add()
        {
            CategoryManager categoryManager = new CategoryManager();
            List<Category> categories = categoryManager.GetCategories();
            return View(categories);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductVM model)
        {
            if (ModelState.IsValid)
            {

                string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image");
                string ImagePath = Guid.NewGuid().ToString() + "_" + model.productImage.FileName;
                string filePath = Path.Combine(uploadsFolder, ImagePath);
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    await model.productImage.CopyToAsync(fs);
                }


                Product product = new Product();
                product.Name = model.Name;
                product.Description = model.Description;
                product.UnitPrice = model.UnitPrice;
                product.CategoryId = model.CategoryId;
                product.MainImage = ImagePath;
                

                ProductManager.Add(product);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
