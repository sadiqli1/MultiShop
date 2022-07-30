using System.ComponentModel.DataAnnotations;

namespace MultiShop.ViewModels
{
	public class RegisterVM
	{
		[Required, StringLength(30)]
		public string Firstname { get; set; }
		[Required, StringLength(30)]
		public string Lastname { get; set; }
		[Required, StringLength(20)]
		public string Username { get; set; }
		[Required, DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required, DataType(DataType.Password)]
		public string Password { get; set; }
		[Required, DataType(DataType.Password), Compare(nameof(Password))]
		public string ConfirmPassword { get; set; }
		[Required]
		public bool Terms { get; set; }
	}
}
