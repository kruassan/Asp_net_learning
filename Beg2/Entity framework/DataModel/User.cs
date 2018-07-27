using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Threading.Tasks;

namespace Beg2.Entity_framework.DataModel
{
	[Serializable]
	[Table("User", Schema = "public")]
	public class User
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string Login { get; set; }

		public string Pass_hash { get; set; }

		public DateTime? Registration_time { get; set; }

		public bool? Banned { get; set; }

		public DateTime? Ban_end { get; set; }

		public long? Id { get; set; }

		
	}
}