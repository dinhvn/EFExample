using EFExample.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EFExample.Common
{
	public abstract class ApiControllerBase: ApiController
	{
		protected EFDataContext db = new EFDataContext();

		public ApiControllerBase()
		{

		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}