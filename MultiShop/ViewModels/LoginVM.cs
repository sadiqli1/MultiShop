﻿using System.ComponentModel.DataAnnotations;

namespace MultiShop.ViewModels
{
	public class LoginVM
	{
		[Required, StringLength(20)]
		public string Username { get; set; }
		[Required, DataType(DataType.Password)]
		public string Password { get; set; }
		public bool RememberMe { get; set; }
	}
}
