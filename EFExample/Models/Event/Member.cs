using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFExample.Models.Event
{
	public class Member
	{
		public int Id { get; set; }
		public int? IdEvent { get; set; }
		public string Name { get; set; }
	}
}