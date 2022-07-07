using SiemensECommerce.Data.ORM;
using System.ComponentModel.DataAnnotations;

namespace SiemensECommerce.UI.Models.VM
{
    public class RegisterVM
    {

        [Required]
        [MinLength(3, ErrorMessage = "Ad alanı minimum 3 karakter olmalıdır.")]
        public string Name { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Soyadı alanı minimum 2 karakter olmalıdır.")]
        public string SurName { get; set; }



        [Required(ErrorMessage = "Eposta alanı boş bırakamazsınız.")]
        [EmailAddress(ErrorMessage = "Lütfen email formatına uygun bir adres giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz")]
        [MinLength(6, ErrorMessage = "Şifreniz minimum 6 karakter olmalıdır.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre doğrulama alanı boş bırakılamaz")]
        [MinLength(6, ErrorMessage = "Şifreniz minimum 6 karakter olmalıdır.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Telefon numarası alanı boş bırakılamaz.")]
        [Phone(ErrorMessage ="Uygun bir telefon numarası giriniz.")]
        public string PhoneNumber { get; set; }

        
    }
}