using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Data.ORM
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string MainImage { get; set; }

        public decimal UnitPrice { get; set; }

        public int CategoryId { get; set; }


        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
