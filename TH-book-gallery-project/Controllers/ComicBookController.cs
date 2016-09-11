using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TH_book_gallery_project.Controllers {
	//Adding the suffix Controller when naming your class "ComicBookController" is more than a convention, it's a requirement. Without it MVC wouldn't be able to distinguish our website's controllers from other classes in our project
	//Controller classes need to be public. Otherwise MVC won't be able to find and use them
	//Action methods need to be public too, for the same reason
	public class ComicBookController : Controller {
		//Every public method on a controller is an action method. They're responsible for performing any actions that are required to prepare a response for a request
		public ActionResult Detail() {
			//var seriesTitle = "The Amazing Spider-Man";
			//var issueNumber = 700;
			//var description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
			//var artists = new string[] {...};


			//We need to replace our variables with defining properties on the ViewBag object.
			//ViewBag is an object provided by MVC that allows us to pass data from a controller to a view. Since we're switching from using variables to properties, we need to capitalize the first letter of each property name, which is the commonly accepted convention for naming properties.
			//!Note: ViewBag is dynamic type and you won't get any IntelliSense hints

			ViewBag.SeriesTitle = "The Amazing Spider-Man";
			ViewBag.IssueNumber = 700;
			ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
			ViewBag.Artists = new string[]
			{
				"Script: Dan Slott",
				"Pencils: Humberto Ramos",
				"Inks: Victor Olazaba",
				"Colors: Edgar Delgado",
				"Letters: Chris Eliopoulos"
			};
			return View();
		}
	}
}