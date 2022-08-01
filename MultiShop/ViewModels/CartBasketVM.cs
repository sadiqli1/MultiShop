using System.Collections.Generic;
using MultiShop.Models;

namespace MultiShop.ViewModels
{
    public class CartBasketVM
    {
        public List<BasketItemVM> BasketItemVMs { get; set; }
        public decimal ToatlPrice { get; set; }
    }
}