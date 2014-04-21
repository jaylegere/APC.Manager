using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APC.Manager.Web.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {
			ViewBag.Title = "Dashboard";
			ViewBag.ActiveTab = "Dashboard";

			return View();
		}
	}
}