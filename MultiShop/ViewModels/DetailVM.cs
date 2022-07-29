using System.Collections.Generic;
using MultiShop.Models;

namespace MultiShop.ViewModels
{
    public class DetailVM
    {
        public Dress Dress { get; set; }
        public List<Color> Colors { get; set; }
        public List<Size> Sizes { get; set; }
    }
}
