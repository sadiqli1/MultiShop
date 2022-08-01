using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Dress:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Desc { get; set; }
        public int DressInformationId { get; set; }
        public List<Image> Images { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DressInformation DressInformation { get; set; }
        [NotMapped]
        public IFormFile MainPhoto { get; set; }
        [NotMapped]
        public List<IFormFile> Photos { get; set; }
        [NotMapped]
        public List<int> PhotoIds { get; set; }
        [NotMapped, Required]
        public int ColorId { get; set; }
        [NotMapped, Required]
        public int SizeId { get; set; }
        [NotMapped, Required]
        public int Quantity { get; set; } = 1;
    }
}
