using SiemensECommerce.Data.ORM;
using System.ComponentModel.DataAnnotations;

namespace SiemensECommerce.UI.Models.VM
{
    public class ProductVM
    {
        [Required]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int SupplierId { get; set; }
        public int BrandId { get; set; }
        public IFormFile productImage { get; set; }

    }
}
