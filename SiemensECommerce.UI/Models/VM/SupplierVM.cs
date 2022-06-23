using System.ComponentModel.DataAnnotations;

namespace SiemensECommerce.UI.Models.VM
{
    public class SupplierVM
    {
        [Required(ErrorMessage = "Company Name alanı boş bırakılamaz")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Contact Name alanı boş bırakılamaz")]
        public string ContactName { get; set; }
        [Required(ErrorMessage = "Contact Title alanı boş bırakılamaz")]
        public string ContactTitle { get; set; }
        [Required(ErrorMessage = "Address alanı boş bırakılamaz")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Country alanı boş bırakılamaz")]
        public string Country { get; set; }
    }
}
