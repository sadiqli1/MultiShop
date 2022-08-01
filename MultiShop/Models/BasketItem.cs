using MultiShop.Models.Base;
using MultiShop.Models;

namespace MultiShop.Models
{
	public class BasketItem:BaseEntity
	{
		public int DressId { get; set; }
		public Dress Dress { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public string AppUserId { get; set; }
		public AppUser AppUser { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
}