using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
	public class RestourantController : Controller
	{
		private OdeToFoodDb db = new OdeToFoodDb();

		// GET: Restourant
		public ActionResult Index()
		{
			return View(db.Restourants.ToList());
		}

		// GET: Restourant/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Restourant/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,Name,City,Country")] Restourant restourant)
		{
			if (ModelState.IsValid)
			{
				db.Restourants.Add(restourant);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(restourant);
		}

		// GET: Restourant/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Restourant restourant = db.Restourants.Find(id);
			if (restourant == null)
			{
				return HttpNotFound();
			}
			return View(restourant);
		}

		// POST: Restourant/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,Name,City,Country")] Restourant restourant)
		{
			if (ModelState.IsValid)
			{
				db.Entry(restourant).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(restourant);
		}

		// GET: Restourant/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Restourant restourant = db.Restourants.Find(id);
			if (restourant == null)
			{
				return HttpNotFound();
			}
			return View(restourant);
		}

		// POST: Restourant/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			Restourant restourant = db.Restourants.Find(id);
			db.Restourants.Remove(restourant);
			db.SaveChanges();
			return RedirectToAction("Index");
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
