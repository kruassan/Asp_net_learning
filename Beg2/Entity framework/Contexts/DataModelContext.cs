using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace Beg2.Entity_framework.Contexts
{
	public class DataModelContext : DbContext
	{
		public DataModelContext() : base("PostgreSql")
		{

		}
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder); // I had removed this
												/// Rest of on model creating here.
		}





	}
}