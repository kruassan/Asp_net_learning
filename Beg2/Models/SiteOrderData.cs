using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beg2.Models
{
	public class SiteOrderData
	{
		public int price { get; set; }

		public string nominal { get; set; }

		public DateTime deadLineTime { get; set; }

		public string connectEmail { get; set; }

		public string orderInfo { get; set; }
	}
}