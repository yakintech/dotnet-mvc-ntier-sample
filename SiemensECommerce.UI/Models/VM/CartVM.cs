namespace SiemensECommerce.UI.Models.VM
{
    public class CartVM
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Img { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }

    }
}
