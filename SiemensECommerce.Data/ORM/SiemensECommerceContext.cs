using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Data.ORM
{
    public class SiemensECommerceContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=37.230.108.246;Database=cagatay8_metroSMSdb;UID=user_metroSMSdb;pwd=3fK@48ek");
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<AdminUser> AdminUsers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<WebUser> WebUsers { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<ForgotPassword> ForgotPasswords { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
    }


}
