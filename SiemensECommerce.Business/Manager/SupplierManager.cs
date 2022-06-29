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
        //public static void Add(Supplier supplier)
        //{
        //    SiemensECommerceContext db = new SiemensECommerceContext();

        //    supplier.IsDeleted = false;
        //    supplier.AddDate = DateTime.Now;

        //    db.Suppliers.Add(supplier);
        //    db.SaveChanges();
        //}
        public Supplier GetSupplierById(int id)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            Supplier supplier = db.Suppliers.FirstOrDefault(c => c.Id == id);

            return supplier;
        }
        public List<Supplier> GetSuppliers()
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            var suppliers = db.Suppliers.Where(x => x.IsDeleted == false).ToList();
            return suppliers;
        }
       public void Delete(int id)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            Supplier supplier = db.Suppliers.FirstOrDefault(q => q.Id == id);

            if (supplier != null)
            supplier.IsDeleted = true;
            db.SaveChanges();

        }
        public void Update (Supplier supplier)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            var updatesupplier =db.Suppliers.FirstOrDefault(q => q.Id == supplier.Id);
            updatesupplier.CompanyName = supplier.CompanyName;
            updatesupplier.ContactName= supplier.ContactName;
            updatesupplier.ContactTitle= supplier.ContactTitle;
            updatesupplier.Address= supplier.Address;
            updatesupplier.Country= supplier.Country;

            db.SaveChanges();


        }
    }
}
