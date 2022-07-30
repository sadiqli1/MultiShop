using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace MultiShop.Models
{
	public class AppUser:IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public List<BasketItem> BasketItems { get; set; }
		public List<Order> Orders { get; set; }
	}
}
