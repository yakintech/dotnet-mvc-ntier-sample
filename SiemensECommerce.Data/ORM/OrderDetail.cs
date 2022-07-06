using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensECommerce.Data.ORM
{
    public class OrderDetail:BaseEntity
    {

        public int OrderId { get; set; }


        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        public int Quantity { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
