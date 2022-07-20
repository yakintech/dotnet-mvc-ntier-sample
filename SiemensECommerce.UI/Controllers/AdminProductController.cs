using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SiemensECommerce.Business.Manager;
using SiemensECommerce.Data.ORM;
using SiemensECommerce.UI.Models.VM;

namespace SiemensECommerce.UI.Controllers
{
    public class AdminProductController : AdminBaseController
    {
        public IActionResult Index()
        {
          
            var products = unitOfWork.ProductRepository.GetAll();
            return View(products);
        }
        public IActionResult Add()
        {
            BrandManager brandManager = new BrandManager();
           ProductListVM products = new ProductListVM();
            products.categories = unitOfWork.CategoryRepository.GetAll();
            products.suppliers = unitOfWork.SupplierRepository.GetAll();
            products.brands = unitOfWork.BrandRepository.GetAll();

            return View(products);
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
                product.SupplierId = model.SupplierId;
                product.BrandId = model.BrandId;
                product.MainImage = ImagePath;
                
                unitOfWork.ProductRepository.Add(product);
                unitOfWork.Save();

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

            
        }

        [HttpGet]

        public IActionResult Update(int id)
        {
            //ProductManager productManager = new ProductManager();
            Product product = unitOfWork.ProductRepository.GetEntityById(id);

            return View(product);
        }

        [HttpPost]

        public IActionResult Update(Product model)
        {
            ProductManager productManager = new ProductManager();

            productManager.Update(model);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
           
            unitOfWork.ProductRepository.Delete(id);
            unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
