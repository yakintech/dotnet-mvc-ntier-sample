using System.ComponentModel.DataAnnotations;

namespace SiemensECommerce.UI.Models.VM
{
    public class ContactVM
    {
        [Required(ErrorMessage = "Name alanı boş bırakılamaz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname alanı boş bırakılamaz")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Email alanı boş bırakılamaz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone alanı boş bırakılamaz")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Message alanı boş bırakılamaz")]
        public string Message { get; set; }
    }
}
