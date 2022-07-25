using System.Collections.Generic;
using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Dress> Dresses { get; set; }
    }
}
