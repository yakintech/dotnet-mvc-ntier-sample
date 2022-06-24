using SiemensECommerce.Data.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Business.Manager
{
    public class BrandManager
    {
        public static void Add(Brand brand)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();

            brand.IsDeleted = false;
            brand.AddDate = DateTime.Now;

            db.Brands.Add(brand);
            db.SaveChanges();
        }
        public List<Brand> GetBrands()
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            var brand =db.Brands.Where(x => x.IsDeleted==false).ToList();  
            return brand;
        }
        public Brand GetSupplierById(int id)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            Brand brandaa = db.Brands.FirstOrDefault(c => c.Id == id);

            return brandaa;
        }

        public void Delete(int id)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            Brand brand = db.Brands.FirstOrDefault(q => q.Id == id);
                {
                if (brand != null)
                {
                    brand.IsDeleted = true;
                    db.SaveChanges();
                }
            }
        }
    }
}
