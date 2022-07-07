using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Data.ORM
{
    public class Cargo : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
