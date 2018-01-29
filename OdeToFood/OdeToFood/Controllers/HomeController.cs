using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
	public class HomeController : Controller
	{
		OdeToFoodDb _db = new OdeToFoodDb();

		public ActionResult Index(string searchTerm = null)
		{
			var model = _db.Restourants.ToList();
			if(searchTerm != null) model = (from r in model where r.Name.ToLower().Contains(searchTerm.ToLower()) orderby r.Name select r).ToList();
			var reviews = _db.Reviews;
			foreach(Restourant rest in model)
			{
				rest.Reviews = (from r in reviews where r.RestourantId == rest.Id orderby r.Rating select r).ToList();
			}
			return View(model);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}