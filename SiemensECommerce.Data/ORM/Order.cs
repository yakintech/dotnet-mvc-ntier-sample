using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Data.ORM
{
    public class Order :BaseEntity
    {
        public string Adress { get; set; }
        public decimal TotalPrice { get; set; }
        public WebUser WebUser { get; set; }

    }
}
