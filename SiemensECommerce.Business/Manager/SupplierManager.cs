using SiemensECommerce.Data.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Business.Manager
{
    public class SupplierManager
    {
        public static void Add(Supplier supplier)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();

            supplier.IsDeleted = false;
            supplier.AddDate = DateTime.Now;

            db.Suppliers.Add(supplier);
            db.SaveChanges();
        }
        public List<Supplier> GetSuppliers()
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            var suppliers = db.Suppliers.Where(x => x.IsDeleted == false).ToList();
            return suppliers;
        }
    }
}
