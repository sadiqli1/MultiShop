using System.Collections.Generic;

namespace MultiShop.ViewModels
{
    public class WishVM
    {
        public List<WishCookieItemVM> WishCookieItemVMs { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
