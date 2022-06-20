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
            var categories = db.Categories.ToList();
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
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            Category category = db.Categories.FirstOrDefault(c => c.Id == id);
            category.IsDeleted = true;

            db.SaveChanges();
        }
    }
}
