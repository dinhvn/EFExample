using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFExample.Models.Event
{
	public class EventCycle
	{
		public int Id { get; set; }
		
		public int IdEvent { get; set; }
		public string Name { get; set; }

		public virtual Event Event { get; set; }
	}
}