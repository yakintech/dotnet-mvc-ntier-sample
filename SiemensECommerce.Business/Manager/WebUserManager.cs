using SiemensECommerce.Data.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Business.Manager
{
    public class WebUserManager
    {
        public List<WebUser> GetWebUsers()
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            var webuser = db.WebUsers.Where(q => q.IsDeleted == false).ToList();
            return webuser;
        }

        public WebUser GetCategoryById(int id)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            WebUser webuser = db.WebUsers.FirstOrDefault(c => c.Id == id);

            return webuser;
        }

        public void Add(WebUser webUser)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            webUser.AddDate = DateTime.Now;
            webUser.IsDeleted = false;


            db.WebUsers.Add(webUser);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            WebUser webUser = db.WebUsers.FirstOrDefault(c => c.Id == id);

            if (webUser != null)
                webUser.IsDeleted = true;

            db.SaveChanges();
        }

        public void Update(WebUser webUser)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();

            //Önce güncellenecek kategori db den bulunur.
            var updateCategory = db.WebUsers.FirstOrDefault(c => c.Id == webUser.Id);

            //sonra bu kateori dışarıdan gelen değer ile güncellenir
            updateCategory.Name = webUser.Name;

            db.SaveChanges();
        }
    }
}
