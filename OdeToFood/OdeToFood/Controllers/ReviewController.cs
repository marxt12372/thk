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
		// GET: Review
		public ActionResult Index()
		{
			var model = from r in reviews orderby r.Rating descending select r;
			return View(model);
		}

		// GET: Review/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: Review/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Review/Create
		[HttpPost]
		public ActionResult Create(FormCollection collection)
		{
			try
			{
				// TODO: Add insert logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: Review/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: Review/Edit/5
		[HttpPost]
		public ActionResult Edit(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add update logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: Review/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: Review/Delete/5
		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add delete logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		static List<RestourantReview> reviews = new List<RestourantReview>(){
			new RestourantReview{Id = 0, Name = "Linnutee puhvet", City = "Tallinn", Country = "Estonia", Rating = 10.0f },
			new RestourantReview{Id = 1, Name = "Räägupesa", City = "Tallinn", Country = "Estonia", Rating = 4.0f },
			new RestourantReview{Id = 2, Name = "Staap", City = "Tallinn", Country = "Estonia", Rating = 6.0f }
		};
    }
}
