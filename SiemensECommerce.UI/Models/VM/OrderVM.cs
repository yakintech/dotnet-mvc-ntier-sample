using SiemensECommerce.Data.ORM;
using System.ComponentModel.DataAnnotations;

namespace SiemensECommerce.UI.Models.VM
{
    public class OrderVM
    {


        [Required(ErrorMessage = "Adress boş bırakılamaz")]
         public string Adress { get; set; }

        [Required(ErrorMessage = "Total Price boş bırakılamaz.")]
        public decimal TotalPrice { get; set; }
   
        [Required(ErrorMessage = "FirstName alanı boş bırakılamaz")]
        public WebUser WebUser { get; set; }

    }
}
