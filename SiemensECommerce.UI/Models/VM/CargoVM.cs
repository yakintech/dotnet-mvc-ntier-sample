
using System.ComponentModel.DataAnnotations;

namespace SiemensECommerce.UI.Models.VM
{
    public class CargoVM 
    {
        [Required(ErrorMessage = "Name Alanı boş geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description Alanı boş geçilemez")]
        public string Description { get; set; }
    }
}
