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
        GenericRepository<Brand> brandRepository;
        GenericRepository<WebUser> webUserRepository;
        GenericRepository<Order> orderRepository;
        GenericRepository<OrderDetail> orderdetailRepository;
        GenericRepository<Contact> contactRepository;
        GenericRepository<Cargo> cargoRepsitory;

        public GenericRepository<Cargo> CargoRepository
        {
            get
            {
                if(this.cargoRepsitory == null)
                {
                    this.cargoRepsitory = new GenericRepository<Cargo>(siemensECommerceContext);
                }
                return this.cargoRepsitory;
            }
        }

        public GenericRepository<Contact> ContactRepository
        {
            get
            {
                if (this.contactRepository == null)
                {
                    this.contactRepository = new GenericRepository<Contact>(siemensECommerceContext);
                }
                return this.contactRepository;
            }
        }
        public GenericRepository<Brand> BrandRepository
        {
            get
            {
                if(this.brandRepository == null)
                {
                    this.brandRepository = new GenericRepository<Brand>(siemensECommerceContext);
                }
                return this.brandRepository;
            }
        }
        public GenericRepository<Supplier> SupplierRepository { 
            get
            {
                if (this.supplierRepository == null)
                {
                    this.supplierRepository = new GenericRepository<Supplier>(siemensECommerceContext);
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
                    this.productRepository = new GenericRepository<Product>(siemensECommerceContext);
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
                    this.categoryRepository = new GenericRepository<Category>(siemensECommerceContext);
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
                    this.adminuserRepository = new GenericRepository<AdminUser>(siemensECommerceContext);
                }
                return adminuserRepository;
            }

        }

        public GenericRepository<WebUser> WebUserRepository
        {
            get
            {
                if (this.webUserRepository == null)
                {
                    this.webUserRepository = new GenericRepository<WebUser>(siemensECommerceContext);
                }
                return webUserRepository;
            }

        }

        public GenericRepository<Order> OrderRepository
        {
            get
            {
                if (this.orderRepository == null)
                {
                    this.orderRepository = new GenericRepository<Order>(siemensECommerceContext);
                }
                return orderRepository;
            }

        }
        public GenericRepository<OrderDetail> OrderDetailRepository
        {
            get
            {
                if (this.orderdetailRepository == null)
                {
                    this.orderdetailRepository = new GenericRepository<OrderDetail>(siemensECommerceContext);
                }
                return orderdetailRepository;
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
