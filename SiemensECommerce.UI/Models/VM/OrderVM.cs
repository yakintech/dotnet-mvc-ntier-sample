using System.ComponentModel.DataAnnotations;

namespace SiemensECommerce.UI.Models.VM
{
    public class OrderVM
    {


        [Required(ErrorMessage = "Adress alanı boş bırakılamaz")]
 
        public string Adress { get; set; }


        [Required(ErrorMessage = "Phone alanı boş bırakılamaz")]
        [MinLength(11, ErrorMessage = "Phone minimum 11 karakter olmalıdır")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "FirstName alanı boş bırakılamaz")]
       
        public string FirstName { get; set; }


        [Required(ErrorMessage = "LastName alanı boş bırakılamaz")]
        
        public string LastName { get; set; }

        [Required(ErrorMessage = "EMail alanı boş bırakılamaz")]
        [EmailAddress(ErrorMessage = "Lütfen email formatına uygun bir değer giriniz")]
        public string EMail { get; set; }





    }
}
