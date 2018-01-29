using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
	public class ReviewController : Controller
	{
		OdeToFoodDb _db = new OdeToFoodDb();
		// GET: Review
		public ActionResult Index([Bind(Prefix="id")] int restourantId)
		{
			var restourant = _db.Restourants.Find(restourantId);
			if(restourant != null)
			{
				return View(restourant.Reviews);
			}
			else return HttpNotFound();
		}
	}
}
