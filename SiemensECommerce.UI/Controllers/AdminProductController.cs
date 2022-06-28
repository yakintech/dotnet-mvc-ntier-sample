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
            ProductManager productManager = new ProductManager();
            var products = productManager.GetProducts();
            return View(products);
        }
        public IActionResult Add()
        {
            CategoryManager categoryManager = new CategoryManager();
            SupplierManager supplierManager = new SupplierManager();
            BrandManager brandManager = new BrandManager();
            ProductListVM model = new ProductListVM();

            model.categories = categoryManager.GetCategories();
            model.suppliers = supplierManager.GetSuppliers();
            model.brands = brandManager.GetBrands();

            return View(model);
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
                
                ProductManager.Add(product);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

            
        }
        public IActionResult Update(int id)
        {
            ProductManager productManager = new ProductManager();
            Product product = productManager.GetProductById(id);

            return View(product);
        }

        public IActionResult Update(Product model)
        {
            ProductManager productManager = new ProductManager();

            productManager.Update(model);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            ProductManager productManager = new ProductManager();
            productManager.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
