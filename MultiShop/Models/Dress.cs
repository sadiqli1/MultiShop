﻿using System.Collections.Generic;
using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Dress:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Desc { get; set; }
        public int DresInformationId { get; set; }
        public List<Image> Images { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DressInformation DressInformation { get; set; }
    }
}
