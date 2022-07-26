using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class DressInformation:BaseEntity
    {
        [Required, StringLength(40)]
        public string Name { get; set; }
        [Required]
        public string Article { get; set; }
        public List<Dress> Dresses { get; set; }
    }
}