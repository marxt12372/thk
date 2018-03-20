using HirmudeMaja.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HirmudeMaja.Controllers
{
	public class HomeController:Controller
	{
		HirmudeMajaDB _db = new HirmudeMajaDB();

		public static int GetCurrentTime()
		{
			return (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
		}

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Buy()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Buy([Bind(Include = "Eesnimi")] Visitor visitor)
		{
			visitor.Sisenes = -1;
			visitor.Lahkus = -1;
			_db.Visitors.Add(visitor);
			_db.SaveChanges();
			return RedirectToAction("Buy", "Home");
		}

		public ActionResult Sisenes(int id)
		{
			Visitor visitor = _db.Visitors.Find(id);
			visitor.Sisenes = GetCurrentTime();
			_db.Entry(visitor).State = EntityState.Modified;
			_db.SaveChanges();
			return RedirectToAction("Tickets", "Home");
		}

		public ActionResult Lahkus(int id)
		{
			Visitor visitor = _db.Visitors.Find(id);
			visitor.Lahkus = GetCurrentTime();
			_db.Entry(visitor).State = EntityState.Modified;
			_db.SaveChanges();
			return RedirectToAction("Tickets", "Home");
		}

		public ActionResult Tickets()
		{
			var model = from r in _db.Visitors.ToList() where (r.Sisenes == -1 || r.Lahkus == -1) select r;
			return View(model);
		}

		public ActionResult Visitors()
		{
			var model = _db.Visitors.ToList();
			return View(model);
		}
	}
}