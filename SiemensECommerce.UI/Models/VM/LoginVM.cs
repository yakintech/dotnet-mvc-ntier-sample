using System.ComponentModel.DataAnnotations;


namespace SiemensECommerce.UI.Models.VM
{
    public class LoginVM
    {

        [Required(ErrorMessage = "EMail alanı boş bırakılamaz")]
        [EmailAddress(ErrorMessage = "Lütfen email formatına uygun bir değer giriniz")]
        public string email { get; set; }



        [Required(ErrorMessage = "Password alanı boş bırakılamaz")]
        [MinLength(6, ErrorMessage = "Password minimum 6 karakter olmalıdır")]
        public string password { get; set; }
    }
}
