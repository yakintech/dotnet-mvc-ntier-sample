using SiemensECommerce.Data.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Business.Manager
{
    public class CategoryManager
    {

        //Tüm kategorileri bana veren bir metot!!
        public List<Category> GetCategories()
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            var categories = db.Categories.Where(q => q.IsDeleted == false).ToList();
            return categories;
        }

        public Category GetCategoryById(int id)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            Category category = db.Categories.FirstOrDefault(c => c.Id == id);

            return category;
        }

        public void Add(Category category)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            category.AddDate = DateTime.Now;
            category.IsDeleted = false;


            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            Category category = db.Categories.FirstOrDefault(c => c.Id == id);
            
            if(category != null)
            category.IsDeleted = true;

            db.SaveChanges();
        }

        public void Update(Category category)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();

            //Önce güncellenecek kategori db den bulunur.
            var updateCategory = db.Categories.FirstOrDefault(c => c.Id == category.Id);

            //sonra bu kateori dışarıdan gelen değer ile güncellenir
            updateCategory.Name = category.Name;

            db.SaveChanges();
        }
    }
}
