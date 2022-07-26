using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Image:BaseEntity
    {
        public string Name { get; set; }
        public string Alternative { get; set; }
        public bool? isMain { get; set; }
        public int DressId { get; set; }
        public Dress Dress { get; set; }
    }
}
