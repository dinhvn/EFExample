using EFExample.Models.Event;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EFExample.DataContext.EFConfiguration
{
	public class EventCycleConfiguration : EntityTypeConfiguration<EventCycle>
	{
		public EventCycleConfiguration()
		{
			ToTable("T_EVENT_CYCLE");
			HasKey(e => e.Id);
			Property(e => e.Id).HasColumnName("ID");
			Property(e => e.IdEvent).HasColumnName("ID_EVENT");
			Property(e => e.Name).HasColumnName("NAME");

			HasRequired<Event>(s => s.Event)
					.WithMany(s => s.EventCycles)
					.HasForeignKey(s => s.IdEvent);
		}
	}
}