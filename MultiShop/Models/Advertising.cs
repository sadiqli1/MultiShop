using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Advertising:BaseEntity
    {
        [Required, StringLength(20)]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required]
        public byte Discount { get; set; }
        [Required]
        public string Url { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
