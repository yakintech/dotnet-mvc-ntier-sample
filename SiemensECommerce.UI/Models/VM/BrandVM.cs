using System.ComponentModel.DataAnnotations;

namespace SiemensECommerce.UI.Models.VM
{
    public class BrandVM
    {
        [Required(ErrorMessage = "Name alanı boş bırakılamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Country alanı boş bırakılamaz")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Address alanı boş bırakılamaz")]
        public string Address { get; set; }
        public IFormFile logoImage { get; set; }
     
  
    }
}
