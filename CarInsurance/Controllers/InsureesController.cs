﻿using CarInsurance.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
	public class InsureesController : Controller
	{
		private InsuranceEntities db = new InsuranceEntities();

		// GET: Insurees
		public ActionResult Index()
		{
			return View(db.Insurees.ToList());
		}

		public ActionResult Admin()
		{
			return View(db.Insurees.ToList());
		}

		// GET: Insurees/Details/5
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Insuree insuree = db.Insurees.Find(id);
			if (insuree == null)
			{
				return HttpNotFound();
			}
			return View(insuree);
		}

		// GET: Insurees/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Insurees/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddres,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Coverage,Quote")] Insuree insuree)
		{
			if (ModelState.IsValid)
			{
				Quote(insuree);
				db.Insurees.Add(insuree);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(insuree);
		}

		// GET: Insurees/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Insuree insuree = db.Insurees.Find(id);
			if (insuree == null)
			{
				return HttpNotFound();
			}
			return View(insuree);
		}

		// POST: Insurees/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddres,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Coverage,Quote")] Insuree insuree)
		{
			if (ModelState.IsValid)
			{
				db.Entry(insuree).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(insuree);
		}

		// GET: Insurees/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Insuree insuree = db.Insurees.Find(id);
			if (insuree == null)
			{
				return HttpNotFound();
			}
			return View(insuree);
		}

		// POST: Insurees/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			Insuree insuree = db.Insurees.Find(id);
			db.Insurees.Remove(insuree);
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

		// Calculate quote total
		public void Quote(Insuree insuree)
		{
			Decimal quote = 50.00m;
			int age = DateTime.Now.Year - Convert.ToDateTime(insuree.DateOfBirth).Year;
			if (age <= 18)
			{
				quote += 100.00m;
			}
			else if (age >= 19 && age <= 25)
			{
				quote += 50.00m;
			}
			else
			{
				quote += 25.00m;
			}

			if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
			{
				quote += 25;
			}

			if (insuree.CarMake.ToLower() == "porsche")
			{
				quote += 25.00m;
				if (insuree.CarModel.ToLower() == "911 carrera")
				{
					quote += 25.00m;
				}
			}

			if (insuree.SpeedingTickets > 0)
			{
				quote += insuree.SpeedingTickets * 10;
			}

			if (insuree.DUI)
			{
				decimal DUI = 0.25m * quote;
				quote += DUI;
			}

			if (insuree.CoverageType)
			{
				decimal fullCoverage = 0.25m * quote;
				quote += fullCoverage;
			}

			insuree.Quote = Math.Round(quote);

		}
	}
}
