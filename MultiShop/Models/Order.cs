using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MultiShop.Models.Base;
using MultiShop.ViewModels;

namespace MultiShop.Models
{
	public class Order:BaseEntity
	{
		public DateTime Date{ get; set; }
		public decimal TotalPrice { get; set; }
		public bool? Status { get; set; }
		[Required]
		public string Addres { get; set; }
		public List<BasketItem> BasketItems { get; set; }
		public string AppUserId { get; set; }
		public AppUser AppUser { get; set; }
	}
}
