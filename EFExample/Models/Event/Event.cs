using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFExample.Models.Event
{
	public class Event
	{
		public Event()
		{
			EventCycles = new List<EventCycle>();
		}

		public int Id { get; set; }
		public string Name { get; set; }

		public virtual EventContent EventContent { get; set; }

		public virtual ICollection<EventCycle> EventCycles { get; set; }
	}
}