using System.ComponentModel.DataAnnotations;


namespace SiemensECommerce.UI.Models.VM
{
    public class CategoryUpdateVM
    {
        [Required(ErrorMessage = "Kategori adı boş bırakılamaz boş bırakılamaz")]
        public string Name { get; set; }

        
    }
}
