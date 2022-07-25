using System.Collections.Generic;
using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class DressInformation:BaseEntity
    {
        public string Name { get; set; }
        public List<Dress> Dresses { get; set; }
    }
}
