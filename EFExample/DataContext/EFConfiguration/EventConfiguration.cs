using EFExample.Models.Event;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EFExample.DataContext.EFConfiguration
{
	public class EventConfiguration : EntityTypeConfiguration<Event>
	{
		public EventConfiguration()
		{
			ToTable("T_EVENT");
			HasKey(e => e.Id);
			Property(e => e.Id).HasColumnName("ID");
			Property(e => e.Name).HasColumnName("NAME");
			HasRequired(s => s.EventContent)
				.WithRequiredPrincipal(ad => ad.Event);
		}
	}
}