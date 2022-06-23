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
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS; Database=SiemensECommerce; trusted_connection = true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Product> Products { get; set; }
<<<<<<< HEAD
        public DbSet<Supplier> Suppliers { get; set; }

=======
        public DbSet<WebUser> WebUsers { get; set; }
>>>>>>> 1334b595ce097b39ab88a6cad48f3b7158cf9e58

    }
}
