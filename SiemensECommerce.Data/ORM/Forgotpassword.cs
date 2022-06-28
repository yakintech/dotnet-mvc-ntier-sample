using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Data.ORM
{
    public class ForgotPassword
    {
        public int ID { get; set; }

        public string Token { get; set; }

        public DateTime ExpiredDate { get; set; }

        public bool Completed { get; set; }

    public AdminUser AdminUser { get; set; }

    }
}

