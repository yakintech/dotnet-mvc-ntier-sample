using System.ComponentModel.DataAnnotations;

namespace SiemensECommerce.UI.Models.VM
{
    public class AdminUserVM
    {
        [Required(ErrorMessage = "EMail alanı boş bırakılamaz")]
        [EmailAddress(ErrorMessage = "Lütfen email formatına uygun bir değer giriniz")]
        public string EMail { get; set; }



        [Required(ErrorMessage = "Password alanı boş bırakılamaz")]
        [MinLength(6, ErrorMessage = "Password minimum 6 karakter olmalıdır")]
        public string Password { get; set; }



        [Compare("Password", ErrorMessage = "Password ve Confirm Password alanları aynı olmak zorunda")]
        [Required(ErrorMessage = "Confirm Password alanı boş bırakılamaz")]
        public string ConfirmPassword { get; set; }
    }
}
