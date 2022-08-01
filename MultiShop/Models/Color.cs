using System.ComponentModel.DataAnnotations;
using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Color:BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
