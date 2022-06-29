using Microsoft.EntityFrameworkCore;
using SiemensECommerce.Data.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Business.Repository
{
    public class GenericRepository<T> where T : BaseEntity
    {
        internal SiemensECommerceContext context;
        internal DbSet<T> dbSet;

        public GenericRepository()
        {
            context = new SiemensECommerceContext();
            this.dbSet = context.Set<T>();
        }



        public void Add(T entity)
        {
            entity.IsDeleted = false;
            entity.AddDate = DateTime.Now;

            dbSet.Add(entity);

            context.SaveChanges();

        }


    }
}
