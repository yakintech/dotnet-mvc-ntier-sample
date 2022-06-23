using System.ComponentModel.DataAnnotations;

namespace SiemensECommerce.UI.Models.VM
{
    public class WebUserVM
    {
        [Required(ErrorMessage = "Namwe Name alanı boş bırakılamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "SurName Name alanı boş bırakılamaz")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Email Title alanı boş bırakılamaz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password alanı boş bırakılamaz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "PhoneNumber alanı boş bırakılamaz")]
        public string PhoneNumber { get; set; }
    }
}
