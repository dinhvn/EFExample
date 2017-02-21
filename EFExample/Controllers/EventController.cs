using EFExample.Common;
using EFExample.Models.Event;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EFExample.Controllers
{
	public class EventController: ApiControllerBase
	{
		// GET: api/Promotion
		[Route(ApiConfig.ApiRoot + "/Event")]
		[HttpGet]
		public IQueryable<EventItem> GetPromotions()
		{
			return db.Events
				.Include(x => x.EventContent)
				.Include(x => x.EventCycles)
				.Select(e => new EventItem()
			{
				IdEvent = e.Id,
				Name = e.Name,
				NameConent = e.EventContent.Name,
				//NameCycle = e.EventCycles.SelectMany(x =>x.Name)
			});
		}
	}
}