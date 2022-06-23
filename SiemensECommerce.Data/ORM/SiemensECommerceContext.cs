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
<<<<<<< HEAD
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS; Database=Ekip; trusted_connection = true");
=======
            optionsBuilder.UseSqlServer(GetDatabaseConnectionStringFromEnvironment());
        }


        static string GetDatabaseConnectionStringFromEnvironment()
        {
            return Environment.GetEnvironmentVariable("db_connection");
>>>>>>> 6798df710cb95e15b7a2e11ab9206838f88f7790
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<WebUser> WebUsers { get; set; }

   

    }


}
