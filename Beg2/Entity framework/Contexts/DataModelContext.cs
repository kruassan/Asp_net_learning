using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using Beg2.Entity_framework.DataModel;

namespace Beg2.Entity_framework.Contexts
{
	public class DataModelContext : DbContext
	{
		private string schema;

		public DataModelContext(string schema) : base("AppDatabaseConnectionString")
		{
			this.schema = schema;
		}

		protected override void OnModelCreating(DbModelBuilder builder)
		{
			builder.HasDefaultSchema(this.schema);
			base.OnModelCreating(builder);
		}

		public DbSet<User> Users { get; set; }

		public DbSet<News> Newss { get; set; }
	}
}