using Microsoft.EntityFrameworkCore;
using SiemensECommerce.Data.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Business.Manager
{
    public class ProductManager
    {
        public static void Add(Product product)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();

            product.IsDeleted = false;
            product.AddDate = DateTime.Now;

            db.Products.Add(product);
            db.SaveChanges();
        }
        public List<Product> GetProducts()
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            var products = db.Products.Include(x => x.Category).Where(q => q.IsDeleted == false).ToList();

            return products;
        }
        public Product GetProductById(int id)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            Product product = db.Products.FirstOrDefault(x => x.Id == id);
            return product;
        }
        public void Update(Product product)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            var updateproduct = db.Products.FirstOrDefault(q => q.Id == product.Id);
            updateproduct.Name = product.Name;
            updateproduct.Description = product.Description;
            updateproduct.MainImage=product.MainImage;
            updateproduct.UnitPrice = product.UnitPrice;

            db.SaveChanges();
        }

        public void Delete (int id)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            Product product= db.Products.FirstOrDefault(x => x.Id == id);

            if (product != null)
                product.IsDeleted = true;
            db.SaveChanges();
        }
    }
}
