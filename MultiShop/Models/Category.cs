using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Category:BaseEntity
    {
        [Required, StringLength(20)]
        public string Name { get; set; }
        public string Image { get; set; }
        public List<Dress> Dresses { get; set; }
        [NotMapped] 
        public IFormFile Photo { get; set; }
    }
}
