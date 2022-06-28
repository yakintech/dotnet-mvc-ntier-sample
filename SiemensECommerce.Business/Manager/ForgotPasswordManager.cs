using SiemensECommerce.Data.ORM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SiemensECommerce.Business.Manager
{
    public class ForgotPasswordManager
    {
        public List<ForgotPassword> GetAllForgotPassword()
        {
            var ctx = new SiemensECommerceContext();
            return ctx.ForgotPasswords.ToList();
        }


        public ForgotPassword GetForgotPassword(int userId)
        {
            return new SiemensECommerceContext().ForgotPasswords.FirstOrDefault(q => q.AdminUser.Id == userId);
        }



        public void Add(ForgotPassword fp)
        {
            var ctx = new SiemensECommerceContext();
            ctx.ForgotPasswords.Add(fp);
            ctx.SaveChanges();
        }



    }

}