using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Data.ORM
{
    public class AdminUser : BaseEntity
    {
        public string EMail { get; set; }

        public string Password { get; set; }

        public DateTime LastLoginDate { get; set; }
    }
}
