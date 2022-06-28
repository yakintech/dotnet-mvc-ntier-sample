using SiemensECommerce.Data.ORM;

namespace SiemensECommerce.UI.Models.VM
{
    public class ProductListVM
    {
        public List<Category> categories { get; set; }
        public List<Product> products { get; set; }
        public List<Supplier> suppliers { get; set; }
        public List<Brand> brands { get; set; }

    }
}
