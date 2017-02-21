using EFExample.Models.Event;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EFExample.DataContext.EFConfiguration
{
	public class EventCycleDetailConfiguration : EntityTypeConfiguration<EventCycleDetail>
	{
		public EventCycleDetailConfiguration()
		{
			ToTable("T_EVENT_CYCLE_DETAIL");
			HasKey(e => e.Id);
			Property(e => e.Id).HasColumnName("ID");
			Property(e => e.IdCycle).HasColumnName("ID_CYCLE");
			Property(e => e.Name).HasColumnName("NAME");
		}
	}
}