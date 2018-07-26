using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Beg2.Models
{
	public class AuthentificationData
	{
		[Required(ErrorMessage = "Please, enter your login")]
		[RegularExpression(@"^\w+$", ErrorMessage = "Please, use correct login. Use only numbers and letters.")]
		public string login { get; set; }


		[Required(ErrorMessage = "Please, enter your password")]
		public string password { get; set; }

		[Required(ErrorMessage = "Please, select smth")]
		public bool? remember { get; set; }
	}
}