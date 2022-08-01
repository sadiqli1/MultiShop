using MultiShop.Models;

namespace MultiShop.ViewModels
{
    public class BasketItemVM
    {
        public Dress Dress { get; set; }
        public int Quantity { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
}
