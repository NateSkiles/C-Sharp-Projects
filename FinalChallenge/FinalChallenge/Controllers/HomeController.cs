using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalChallenge.Models;

namespace FinalChallenge.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			using (var context = new SchoolContext())
			{
				var student = new Student() { StudentName = "Nate", DateOfBirth = DateTime.Parse("07/07/1994"), LetterGrade = 'A'};

				context.Students.Add(student);
				context.SaveChanges();
			}
			return View();
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