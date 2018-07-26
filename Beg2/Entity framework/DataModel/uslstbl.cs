using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Beg2.Entity_framework.DataModel
{
	[Serializable]
	[Table("uslstbl", Schema = "public")]
	public class uslstbl
	{
		[Key]
		public long kek { get; set; }
	}
}