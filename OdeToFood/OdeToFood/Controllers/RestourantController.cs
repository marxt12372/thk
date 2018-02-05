﻿using System;
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

		public ActionResult Autocomplete(string term)
		{
			var model = db.Restourants.Where(r => r.Name.StartsWith(term)).Take(10).Select(r => new { label = r.Name });
			return Json(model, JsonRequestBehavior.AllowGet);
		}

		public ActionResult Index(string searchTerm = null)
		{
			var model = db.Restourants.ToList();
			if(searchTerm != null && searchTerm != "") model = (from r in model where r.Name.ToLower().Contains(searchTerm.ToLower()) orderby r.Name select r).ToList();
			if(Request.IsAjaxRequest()) return PartialView("_Restourants", model);
			return View(model);
		}

		public ActionResult Create()
		{
			return View();
		}

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

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			Restourant restourant = db.Restourants.Find(id);
			List<RestourantReview> reviews = (from r in db.Reviews.ToList() where r.RestourantId == restourant.Id select r).ToList();
			db.Restourants.Remove(restourant);
			foreach(RestourantReview review in reviews)
			{
				db.Reviews.Remove(review);
			}
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