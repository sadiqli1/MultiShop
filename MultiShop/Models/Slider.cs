using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Slider:BaseEntity
    {
        public string Image { get; set; }
        [Required, StringLength(20)]
        public string Title { get; set; }
        [Required, StringLength(50)]
        public string SubTitle { get; set; }
        [Required]
        public string ButtonUrl { get; set; }
        [Required]
        public byte Order { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
