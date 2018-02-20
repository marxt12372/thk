using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EventsController : Controller
    {
		EventsDatabase db = new EventsDatabase();

		// GET: Events
		public ActionResult Index()
        {
			List<Events> events = db.Events.ToList();
            return View(events);
        }

		public ActionResult Event(int id)
		{
			Events events = db.Events.Find(id);
			return View(events);
		}

		public ActionResult Create()
		{
			return View("Create");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Events events)
		{
			if(ModelState.IsValid)
			{
				db.Events.Add(events);
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return Create();
		}
    }
}