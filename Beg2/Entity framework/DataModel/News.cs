using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beg2.Entity_framework.DataModel
{
	public class News
	{
		public long? Id { get; set; }

		public char[] Caption { get; set; }

		public string Content { get; set; }

		public long[] News_images_id { get; set; }
	}
}