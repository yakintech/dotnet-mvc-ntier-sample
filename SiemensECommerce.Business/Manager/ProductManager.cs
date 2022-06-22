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
    }
}
