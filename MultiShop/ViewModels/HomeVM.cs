using System.Collections.Generic;
using MultiShop.Models;

namespace MultiShop.ViewModels
{
    public class HomeVM
    {
        public List<Dress> Dresses { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Category> Categories { get; set; }
    }
}
