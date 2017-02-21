using EFExample.Models.Event;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EFExample.DataContext.EFConfiguration
{
	public class EventContentConfiguration : EntityTypeConfiguration<EventContent>
	{
		public EventContentConfiguration()
		{
			ToTable("T_EVENT_CONTENT");
			HasKey(e => e.Id);
			HasKey(e => e.IdEvent);
			Property(e => e.Id).HasColumnName("ID");
			Property(e => e.IdEvent).HasColumnName("ID_EVENT");
			Property(e => e.Name).HasColumnName("NAME");
		}
	}
}