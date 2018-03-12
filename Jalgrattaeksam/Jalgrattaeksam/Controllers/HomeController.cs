using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jalgrattaeksam.Models;
using System.Data.Entity;

namespace Jalgrattaeksam.Controllers
{
	public class HomeController:Controller
	{
		JalgrattaeksamDb db = new JalgrattaeksamDb();

		public ActionResult Index()
		{
			var model = db.Eksamineeritavad.ToList();
			return View(model);
		}

		public ActionResult Teooriaeksam()
		{
			var model = from e in db.Eksamineeritavad.ToList() where e.Teooriaeksam <= 0 select e;
			return View(model);
		}

		public ActionResult Teooraieksam(int Id, int Teooriaeksam)
		{
			Eksamineeritavad eksamineeritav = db.Eksamineeritavad.Find(Id);
			eksamineeritav.Teooriaeksam = Teooriaeksam;
			db.Entry(eksamineeritav).State = EntityState.Modified;
			db.SaveChanges();
			return RedirectToAction("Teooriaeksam");
		}

		public ActionResult Slaalom()
		{
			var model = from e in db.Eksamineeritavad.ToList() where (e.Slaalom <= 0 && e.Teooriaeksam >= 1) select e;
			return View(model);
		}

		public ActionResult UpdateSlaalomPositiivne(int id)
		{
			Eksamineeritavad eksamineeritav = db.Eksamineeritavad.Find(id);
			eksamineeritav.Slaalom = -eksamineeritav.Slaalom + 1;
			db.Entry(eksamineeritav).State = EntityState.Modified;
			db.SaveChanges();
			return RedirectToAction("Slaalom");
		}

		public ActionResult UpdateSlaalomNegatiivne(int id)
		{
			Eksamineeritavad eksamineeritav = db.Eksamineeritavad.Find(id);
			eksamineeritav.Slaalom = eksamineeritav.Slaalom - 1;
			db.Entry(eksamineeritav).State = EntityState.Modified;
			db.SaveChanges();
			return RedirectToAction("Slaalom");
		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Eesnimi,Perenimi")]Eksamineeritavad eksamineeritav)
		{
			if(ModelState.IsValid)
			{
				db.Eksamineeritavad.Add(eksamineeritav);
				db.SaveChanges();
			}
			return RedirectToAction("Index");
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}