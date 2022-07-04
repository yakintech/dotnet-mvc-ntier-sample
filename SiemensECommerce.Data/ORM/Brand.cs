using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Data.ORM
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string LogoImage { get; set; }
      
    }
}
