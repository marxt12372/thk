using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
	public class ReviewController : Controller
	{
		OdeToFoodDb db = new OdeToFoodDb();
		// GET: Review
		public ActionResult Index([Bind(Prefix="id")] int restourantId)
		{
			var restourant = db.Restourants.Find(restourantId);
			if(restourant != null)
			{
				return View(restourant);
			}
			else return HttpNotFound();
		}

		public ActionResult Create(int restourantId)
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,Name,City,Country")]RestourantReview review)
		{
			if (ModelState.IsValid)
			{
				db.Reviews.Add(review);
				db.SaveChanges();
				return RedirectToAction("Index", new { id = review.RestourantId });
			}

			return View(review);
		}

		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			RestourantReview review = db.Reviews.Find(id);
			if (review == null)
			{
				return HttpNotFound();
			}
			return View(review);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Exclude = "RatedBy")] RestourantReview review)
		{
			if (ModelState.IsValid)
			{
				db.Entry(review).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index", new { id = review.RestourantId });
			}
			return View(review);
		}
	}
}
