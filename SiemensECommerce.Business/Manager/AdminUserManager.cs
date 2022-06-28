using SiemensECommerce.Data.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Business.Manager
{
    public class AdminUserManager
    {
        public static bool LoginControl(string email, string password)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();

            bool adminUserControl = db.AdminUsers.Any(q => q.EMail == email && q.Password == password);

            return adminUserControl;


        }
        public AdminUser GetUserById(int id)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            AdminUser adminUser = db.AdminUsers.FirstOrDefault(c => c.Id == id);

            return adminUser;
        }
        public List<AdminUser> GetAdminUsers()
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            var adminusers = db.AdminUsers.Where(x => x.IsDeleted == false).ToList();
            return adminusers;
        }


        public static void Add(AdminUser adminUser)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            adminUser.IsDeleted = false;
            adminUser.AddDate = DateTime.Now;

            db.AdminUsers.Add(adminUser);
            db.SaveChanges();
        }
        public void Update(AdminUser adminUser)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();

            var updateAdminUser = db.AdminUsers.FirstOrDefault(c => c.Id == adminUser.Id);

            updateAdminUser.EMail = adminUser.EMail;
            updateAdminUser.Password = adminUser.Password;
        
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            SiemensECommerceContext db = new SiemensECommerceContext();
            AdminUser adminUser = db.AdminUsers.FirstOrDefault(x => x.Id == id);          

            if (adminUser != null)
                adminUser.IsDeleted = true;

            db.SaveChanges();
        }


    }
}
