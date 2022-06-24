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

    }
}
