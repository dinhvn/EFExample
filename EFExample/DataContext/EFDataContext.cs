using EFExample.DataContext.EFConfiguration;
using EFExample.Models.Event;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFExample.DataContext
{
	public class EFDataContext : DbContext
	{
		static string connStr = ConfigurationManager.ConnectionStrings["EFExampleDbContext"].ConnectionString;
		public EFDataContext() : base(connStr)
		{

		}

		public virtual IDbSet<Event> Events { get; set; }
		public virtual IDbSet<EventContent> EventContents { get; set; }
		public virtual IDbSet<EventCycle> EventCycles { get; set; }
		public virtual IDbSet<EventCycleDetail> EventCycleDetails { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new EventConfiguration());
			modelBuilder.Configurations.Add(new EventContentConfiguration());
			modelBuilder.Configurations.Add(new EventCycleConfiguration());
			modelBuilder.Configurations.Add(new EventCycleDetailConfiguration());
		}
	}
}