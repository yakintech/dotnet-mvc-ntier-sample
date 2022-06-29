using SiemensECommerce.Data.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Business.Repository
{
    public class UnitOfWork : IDisposable
    {
        SiemensECommerceContext siemensECommerceContext = new SiemensECommerceContext();

        GenericRepository<Supplier> supplierRepository;
        GenericRepository<Category> categoryRepository;
        GenericRepository<Product> productRepository;
        GenericRepository<AdminUser> adminuserRepository;



        public GenericRepository<Supplier> SupplierRepository { 
            get
            {
                if (this.supplierRepository == null)
                {
                    this.supplierRepository = new GenericRepository<Supplier>();
                }
                return supplierRepository;
            }
        
        }

        public GenericRepository<Product> ProductRepository
        {
            get
            {
                if (this.productRepository == null)
                {
                    this.productRepository = new GenericRepository<Product>();
                }
                return productRepository;
            }

        }

        public GenericRepository<Category> CategoryRepository
        {
            get
            {
                if (this.categoryRepository == null)
                {
                    this.categoryRepository = new GenericRepository<Category>();
                }
                return categoryRepository;
            }

        }
        public GenericRepository<AdminUser> AdminUserRepository
        {
            get
            {
                if (this.adminuserRepository == null)
                {
                    this.adminuserRepository = new GenericRepository<AdminUser>();
                }
                return adminuserRepository;
            }

        }

        public void Save()
        {
            siemensECommerceContext.SaveChanges();  
        }







        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    siemensECommerceContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
